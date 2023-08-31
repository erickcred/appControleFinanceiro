using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppControleFinanceiro.Entities
{
  public class Produto
  {
    public int Id { get; set; }
    public String Nome { get; set; }
    public String Descricao { get; set; }
    public Decimal Preco { get; set; }
    public Double Peso { get; set; }
  }
}