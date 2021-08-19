using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Segundo_Projeto
{
    static class Aula6
    {
        
        public static void MetodoDaAula()
        {
            /*Console.WriteLine("Fazer um programa para ler um número inteiro X e os dados (nome e preço) de X produtos. Armazene os X produtos em um vetor. Em seguida, mostrar o preço médio dos produtos");

            int X = int.Parse(Console.ReadLine());
            Produto1[] vect = new Produto1[X];

            for (int i = 0; i < X; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Produto1 { Name = name, Price = price };
            }

            double sum = 0.0;
            for (int i = 0; i < X; i++)
            {
                sum += vect[i].Price;
            }

            double avg = sum / X;
            Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));
            */




            Console.WriteLine("Aplicando conceito de List");

            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List Count " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A' : " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A' : " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A' : " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A' : " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine();
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();

            list.Remove("Anna");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();

            list.RemoveAll(x => x[0] == 'M');

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();


            list.RemoveAt(2);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            list.RemoveRange(3,1);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }












        }



        
        









    }
}
