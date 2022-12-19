using System;
using System.Globalization;

namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2022, 12, 25);// Data
            DateTime d2 = new DateTime(2022, 12, 25, 15, 22, 00);// Data e Hora
            DateTime d3 = new DateTime(2022, 12, 25, 15, 22, 00, 500);// Data Hora e Milesegundos

            DateTime d4 = DateTime.Now;//Data de Hoje
            DateTime d5 = DateTime.Today;// Data de Hoje no horario de 0:00 horas
            DateTime d6 = DateTime.UtcNow;// Hora de Agora em UTC

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);

            Console.WriteLine("----------------------------------------------------");

            DateTime d7 = DateTime.Parse("2000-08-15");//Converter string em Data
            DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");//Coverter string em Data e Hora

            Console.WriteLine(d7);
            Console.WriteLine(d8);

            Console.WriteLine("----------------------------------------------------");

            DateTime d9 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);//Converter string em Data em Um formato exato
            DateTime d10 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);//Converter string em Data e hora em Um formato exato
            
            Console.WriteLine(d9);
            Console.WriteLine(d10);


        }
    }
}