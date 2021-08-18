using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Segundo_Projeto
{
    static class Aula5
    {
        
        public static void MetodoDaAula()
        {
            ContaBancária conta;

           Console.WriteLine("Aplicando conceitos de construtores, atributos privados, encapsulamento e properties");
            Console.WriteLine("Faça um programa para cadastrar uma conta bancária, sendo necessário informar o número da conta, nome do titular e deposito inicial ou não.Importante ressaltar que o umero da conta não pode ter alteração, o saldo da conta só pode ser alterado via saque ou deposito, e para cada transação de saque realizada é efetivado uma taxa de desconto de R$5,00. Desta feita a conta pode apresentar saldo negativo.");


            Console.Write("Entre com o numero da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o Nome do titular: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n) ?  ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                conta = new ContaBancária(numConta, titular, depositoInicial);

            }
            else
            {
                conta = new ContaBancária(numConta, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:  ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write(" Entre um valor para deposito:  ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);


            Console.WriteLine();
            Console.Write(" Entre um valor para saque:  ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);


            Console.WriteLine("Fazer um programa para ler um número inteiro N e a altura de N pessoas. Armazene as N alturas em um vetor. E em seguida mostrar a altura média dessas pessoas");
            int N = int.Parse(Console.ReadLine());
            double[] vect = new double[N];
            for (int i = 0; i < N; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for (int i = 0; i< N; i ++ )
            {
                sum += vect[i];
            }

            double avg = sum / N;

            Console.WriteLine("Average heigth = " + avg.ToString("f2", CultureInfo.InvariantCulture));
        }


        
        









    }
}
