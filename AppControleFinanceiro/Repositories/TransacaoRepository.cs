using AppControleFinanceiro.Enums;
using AppControleFinanceiro.Models;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppControleFinanceiro.Repositories
{
  public class TransacaoRepository : ITransacaoRepository
  {
    private LiteDatabase _context;
    private readonly string collectionName = "Trasacoes";
    public TransacaoRepository()
    {
      _context = new LiteDatabase("Filename=C:/database.db;Connection=Shared");
    }

    public List<Transacao> ListarTransacaoes()
    {
      return _context.GetCollection<Transacao>(collectionName)
                      .FindAll()
                      .OrderByDescending(x => x.DataTransacao)
                      .Where(x => x.Ativo == true && x.Situacao == ESituacao.Aberto)
                      .ToList();
    }

    public void CriarTransacao(Transacao transacao)
    {
      _context.GetCollection<Transacao>(collectionName)
                .Insert(transacao);
    }

    public void AtualizarTransacao(Transacao transacao)
    {
      _context.GetCollection<Transacao>(collectionName)
                .Update(transacao);
    }

    public void DeletarTransacao(Transacao transacao)
    {
      transacao.Situacao = ESituacao.Deletada;
      _context.GetCollection<Transacao>(collectionName)
                .Update(transacao);
    }
  }

}