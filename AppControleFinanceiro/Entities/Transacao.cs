using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppControleFinanceiro.Entities;
using AppControleFinanceiro.Enums;

namespace AppControleFinanceiro.Models
{
  public class Transacao
  {
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public Cliente Cliente { get; set; }
    public List<Produto> Produtos { get; private set; }
    public Decimal Total { get; private set; }
    public ETransacaoTipo TransacaoType { get; set; }
    public bool Ativo { get; set; }
    public ESituacao Situacao { get; set; }
    public DateTimeOffset DataTransacao { get; set; }

    public Transacao(string nome, Cliente cliente)
    {
      Nome = nome;
      Cliente = cliente;
      Produtos = new List<Produto>();
      Ativo = true;
      Situacao = ESituacao.Aberto;
    }

    public void AddProduto(Produto produto)
    {
      Produtos.Add(produto);
      GeraValorTotal(true);
    }

    public void RemoveProduto(Produto produto)
    {
      Produtos.Remove(produto);
      GeraValorTotal(false);
    }

    private void GeraValorTotal(bool incluir)
    {
      Total = 0;
      foreach (Produto produto in Produtos)
      {
        if (!incluir && (Total > 0 && produto.Preco <= Total))
          Total -= produto.Preco;
        else
          Total += produto.Preco;
      }
    }

    public void DeletarTransacao(Transacao transacao)
    {
      transacao.Situacao = ESituacao.Deletada;
      transacao.Ativo = false;
    }


    public void FinalizarPagamento(Transacao transacao)
    {
      transacao.Situacao = ESituacao.Paga;
      transacao.Ativo = false;
    }
  }
}