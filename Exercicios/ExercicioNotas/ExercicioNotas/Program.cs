using System;
using System.Globalization;

namespace ExercicioNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Console.WriteLine("Olá, preencha os dados");
            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.Write("Digite a primeira nota: ");
            aluno.N1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            aluno.N2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a terceira nota: ");
            aluno.N3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota Final: "+ aluno.NotaFinal().ToString("F2",CultureInfo.InvariantCulture));

            if (aluno.Aprovado())
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram: "+ aluno.NotaRestante().ToString("F2",CultureInfo.InvariantCulture) + " pontos");
            }

        }
    }
}
