using System;
using System.Globalization;

namespace Segundo_Projeto
{
    static class Aula3
    {
        static void MetodoDaAula()
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Fazer um programa para ler o nome e salário de dois funcionários. Depois mostrar o salário médio dos funcionários. ");

            Console.WriteLine("Insira os dados do primeiro colaborador:");
            Console.WriteLine("Nome:");
            f1.Nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Insira os dados do segundo colaborador:");
            Console.WriteLine("Nome:");
            f2.Nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (f1.Salario + f2.Salario) / 2.0;

            Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}


