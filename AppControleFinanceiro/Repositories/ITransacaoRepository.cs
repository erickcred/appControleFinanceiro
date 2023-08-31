using AppControleFinanceiro.Models;

namespace AppControleFinanceiro.Repositories
{
  public interface ITransacaoRepository
  {
    List<Transacao> ListarTransacaoes();
    void CriarTransacao(Transacao transacao);
    void AtualizarTransacao(Transacao transacao);
    void DeletarTransacao(Transacao transacao);
  }
}