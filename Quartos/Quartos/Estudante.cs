using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quartos
{
    class Estudante
    {
        public string NomeAluno { get; set; }
        public string EmailAluno { get; set; }

        public Estudante(string nome, string email)
        {
            NomeAluno = nome;
            EmailAluno = email;
        }

        public override string ToString()
        {
            return NomeAluno + ", "+ EmailAluno;
        }
    }
}
