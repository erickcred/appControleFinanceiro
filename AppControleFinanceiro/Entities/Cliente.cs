﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppControleFinanceiro.Entities
{
  public class Cliente
  {
    public int Id { get; set; }
    public string Nome { get; set; }
    public List<String> Telefone { get; set; }
  }
}
