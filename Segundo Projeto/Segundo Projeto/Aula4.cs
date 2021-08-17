using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Segundo_Projeto
{
    static class Aula4
    {
        
        public static void MetodoDaAula()
        {

             

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados do produto " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a serem adicionados ao estoque ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a serem removidos do estoque ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);







            Console.WriteLine("Exercício proposto - aplicação de mebros estáticos");
            Console.WriteLine("Fazer um programa para ler um valor numérico qualquer, e daí mostrar quanto seria o valor de uma circunferência e do volume de uma esfera para raio daqueke valor. Informar também o valor de PI com duas casas decimais");
            Console.WriteLine("Versão 1");

            
            Console.WriteLine("entre como valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);
            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Criada segunda versão utilizando a classe calculadora");
            Console.WriteLine("Criada terceira versão incluindo STATIC  na classe e alterando o código chamando diretamente a classe");


        }


        
        









    }
}
