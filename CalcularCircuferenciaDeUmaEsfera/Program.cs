// Fazer um programa para ler um valor numérico qualquer, e daí mostrar quanto seria o valor
// de uma circunferência e do volume de uma esferapara um raio daquele valor. Informar também
// o valor de PI com duas casas decimais.

using System;
using System.Globalization;

namespace CalcularCircuferencia
{
    class Program
    {
        static double Pi = 3.141516;
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            double circ = Circuferencia(n1);
            double vol = Volume(n1);
            Console.WriteLine("A circuferencia de {0} é {1:F2}", n1, circ);
            Console.WriteLine("A Volume de {0} é {1:F2}", n1, vol);
            Console.WriteLine("Valor de Pi é de {0:F2}", Pi);


        }
        static double Circuferencia(double r)
        {
            return 2.0 * Pi * r;
        }
        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}