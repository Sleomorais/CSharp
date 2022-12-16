using ListaFuncionarios;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ListasFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionarios deseja adicionar? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Funcionario #{i} : ");
                Console.Write("Digite o Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Digite o Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o salario: ");
                double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                list.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("digite o id do funcionario que deseja aumentar o salario: ");
            int seachId = int.Parse(Console.ReadLine());

            Funcionario  emp = list.Find(x => x.Id == seachId);

            if(emp != null)
            {
                Console.Write("Digite a porcetagem a ser adicionada: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncrementarSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Id não encontrado");
            }
            Console.WriteLine();

            foreach(Funcionario funcionario in list)
            {
                Console.WriteLine(funcionario);
            }
        }
    }
}