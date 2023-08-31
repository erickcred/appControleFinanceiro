using AppControleFinanceiro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppControleFinanceiro.Repositories
{
  public class TransacaoRepository : ITransacaoRepository
  {
    public TransacaoRepository()
    { }

    public List<Transacao> ListarTransacaoes()
    { return null; }

    public void CriarTransacao(Transacao transacao)
    { }

    public void AtualizarTransacao(Transacao transacao)
    { }

    public void DeletarTransacao(Transacao transacao)
    { }
  }

}