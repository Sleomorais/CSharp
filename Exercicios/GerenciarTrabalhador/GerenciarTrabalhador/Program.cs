using GerenciarTrabalhador.Entities;
using GerenciarTrabalhador.Entities.Enums;
using System;
using System.Globalization;

namespace GerenciarTrabalhador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o Nome do Departamento: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Entre com os dados do trabalhador: ");
            Console.Write("Digite o Nome do Funcionario: ");
            string name = Console.ReadLine();
            Console.Write("Digite o Nivel (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Digite o Salario Base: ");
            double baseSalary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("Quantos contratos para esse trabalhador? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Entre com os dados do contrato {i}: ");
                Console.Write("Data(DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por Hora: ");
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Quantidade de horas: ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }
            Console.WriteLine();
            Console.Write("Entre com o mes e ano para calcular dados: ");
            string monthAndYear = Console.ReadLine();

            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: "+ worker.Name);
            Console.WriteLine("Departamento: "+ worker.Department.Name);
            Console.WriteLine("Ganhos no periodo"+ monthAndYear + " : " + worker.Income(year,month));

        }
    }
}
