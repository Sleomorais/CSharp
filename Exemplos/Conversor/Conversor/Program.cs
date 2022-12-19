using System;
using System.Globalization;

namespace Conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual o valor da cotação? ");
            double cot = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar?");
            double valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double total = ConversorDeMoeda.Coverter(valor, cot);

            Console.WriteLine("Valor total: "+ total + " com Iof de "+ConversorDeMoeda.Iof+"%",CultureInfo.InvariantCulture);
        }
    }
}
