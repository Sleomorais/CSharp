using System;
using System.Globalization;

namespace ExercicioFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.WriteLine("Digite seus dados: ");
            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Dados do Funcionario: ");
            Console.WriteLine(func);
            Console.WriteLine();
            Console.WriteLine("Deseja adicionar qual porcentagem de aumento? ");
            double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(porc);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados do Fucionario: ");
            Console.WriteLine(func);
        }
    }
}
