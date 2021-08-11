using System;
using System.Globalization;

namespace Segundo_Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Resolução exercício de fixação");

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preço1 = 2100.0;
            double preço2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é ${preço1}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preço2}");


            Console.WriteLine("Registro: {0} anos de idade, código {1} e genero: {2}", idade,codigo, genero);


            Console.WriteLine(" Medida com oito casas decimais:" + medida.ToString("f8"));
            Console.WriteLine(" Arredondado (três casas decimais): " + medida.ToString("f3"));
            Console.WriteLine("Separador decimal invariant culture" + medida.ToString("f3", CultureInfo.InvariantCulture));
        }
    }
}
