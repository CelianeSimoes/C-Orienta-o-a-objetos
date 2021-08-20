using System;
using System.Collections.Generic;
using System.Text;

namespace Segundo_Projeto
{
    class Estudante
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public int TempoContrato { get; set; }

        public double Aluguel { get; private set; }
        public double Total { get; private set; }

        public Estudante (string nome, string email, double aluguel, double total)
        {
            Nome = nome;
            Email = email;
            Aluguel = aluguel;
            Total = total;
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }

    }
}
