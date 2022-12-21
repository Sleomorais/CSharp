using System.Globalization;
using System.Collections.Generic;
using Payers.Entities;

namespace Payers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Payer> list = new List<Payer>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax #{i} payer");
                Console.Write("Individual or Company (i/c)?");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual Income: ");
                double annualIncome = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, annualIncome, healthExpenditures));
                }
                else if(ch == 'c')
                {
                    Console.Write("Number of Employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, annualIncome, numberOfEmployees));
                }
            }

            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach (Payer payer in list)
            {
                double tax = payer.Taxes();
                Console.WriteLine(payer.Name +" $ " + tax.ToString("F2",CultureInfo.InvariantCulture));
                sum += tax;
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
