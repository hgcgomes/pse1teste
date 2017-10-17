using System;
using pse1.Util;

namespace pse1.Models
{
    public class Pessoa
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public ESexo Sexo { get; set; }
        public bool Ativo { get; set; }

    }
}