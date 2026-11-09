using System;
using System.Collections.Generic;

namespace SistemaHotel.Models
{
    public class Funcionario
    {
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }
        public DateTime DataAdmissao { get; set; }
        public decimal Salario { get; set; }
        public string StatusFuncionario { get; set; }
    }

    public class FuncionarioCollection : List<Funcionario> { }
}
