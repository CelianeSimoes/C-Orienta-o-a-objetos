using System;
using System.Globalization;

namespace Aula2

{
    static class Aula2
       
    {
        public static void MetodoDaAula()
        {
            Console.WriteLine("Resolução exercício de fixação");
            Console.WriteLine("Digite 3 números: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("Maior = " + n1);
            }
            else if (n2 > n3)
            {
                Console.WriteLine("Maior = " + n2);
            }
            else
            {
                Console.WriteLine("Maior = " + n3);
            }

            Console.WriteLine("Resolvendo um problema sem orientação a objetos");
            Console.WriteLine("Fazeer um programa para ler as medidas dos lados de dosi triangulos X e Y. em seguida, mostrar o valor das areas dos dois trianguloes e dizer qual dos dois triangulos possui a maior area.");

            double xA, xB, xC, yA, yB, yC;
            Console.WriteLine("Entre com as medidas do triangulo X");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("Area de X = " + areaX.ToString("f4",CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y = " + areaY.ToString("f4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X ");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }

            Console.WriteLine("Resolvendo um problema sem orientação a objetos");
            Console.WriteLine("Fazer um programa para ler as medidas dos lados de dosi triangulos X e Y. em seguida, mostrar o valor das areas dos dois trianguloes e dizer qual dos dois triangulos possui a maior area.");

            




        }
    }
}
