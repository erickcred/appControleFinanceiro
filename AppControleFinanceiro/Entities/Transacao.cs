using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppControleFinanceiro.Enums;

namespace AppControleFinanceiro.Models
{
  public class Transacao
  {
    public int Id { get; set; }
    public String Nome { get; set; }
    public String Descricao { get; set; }
    public Decimal Total { get; set; }
    public ETransacaoTipo TransacaoType { get; set; }
    public DateTimeOffset DataTransacao { get; set; }

  }
}