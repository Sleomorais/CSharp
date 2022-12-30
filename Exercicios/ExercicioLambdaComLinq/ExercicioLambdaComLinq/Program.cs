using ExercicioLambdaComLinq.Entities;
using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ExercicioLambdaComLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.Write("Enter salary: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> list = new List<Employee>();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        string email = fields[1];
                        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                        list.Add(new Employee(name, email, salary));
                    }
                }
                Console.WriteLine($"Email of people whose salary is more than {value}:");

                var emails = list.Where(e => e.Salary > value).OrderBy(e => e.Emaill).Select(e => e.Emaill);
                foreach (var email in emails)
                {
                    Console.WriteLine(email);
                }
                var sumSalary = list.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);
                Console.Write("Sum of salary of people whose name starts with 'M': ");
                Console.WriteLine(sumSalary);
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
