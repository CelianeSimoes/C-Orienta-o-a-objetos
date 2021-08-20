using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Segundo_Projeto
{
    static class Aula7
    {
       
        public static void MetodoDaAula()
        {
            Estudante[] vect = new Estudante[10];
            Console.Write("Quantos quartos serão alugados?");
            int n = int.Parse(Console.ReadLine());
            double aluguel = 230.00;
            double total;

            
            
            for (int i = 1; i<= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i} : ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.Write("Tempo de contrato/locação em meses: ");
                int tempo = int.Parse(Console.ReadLine());
                 total = (aluguel * tempo);
                Console.WriteLine("Total valor do contrato: " + total.ToString("f2"), CultureInfo.InvariantCulture);
                vect[quarto] = new Estudante (nome, email, aluguel, total);
                

            }
            Console.WriteLine();
            Console.Write("Quartos ocupados:");

            for (int i = 1; i <= 10; i++)
            
                if (vect [i] != null)
                {
                    Console.WriteLine(i + ": " + vect [i] );
                }
            }












        }



        
        









    }

