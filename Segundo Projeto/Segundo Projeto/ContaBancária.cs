using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Segundo_Projeto
{
    class ContaBancária

    {
        public int NumConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancária(int numConta, string titular, double depositoInicial)
        {
            NumConta = numConta;
            Titular = titular;
            Deposito(depositoInicial);
    
        }

        public ContaBancária(int numConta, string titular)
        {
            NumConta = numConta;
            Titular = titular;
        }

        public void Deposito (double quantia)
        {
            Saldo += quantia;
        }

        public void Saque (double quantia)
        {
            Saldo -= quantia + 5.0;
        }
        public override string ToString()
        {
            return " Conta  "
                + NumConta
                + " , Titular: "
                + Titular
                + " , Saldo: R$ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);

        }
    }



}
