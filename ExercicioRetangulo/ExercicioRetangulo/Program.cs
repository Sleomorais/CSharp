using System;

namespace ExercicioRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.Write("Digite a Altura do Retangulo: ");
            retangulo.Altura = double.Parse(Console.ReadLine());
            Console.Write("Digite a Largura do Retangulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine());

            retangulo.Area();
            retangulo.Perimetro();
            retangulo.Diagonal();

            Console.WriteLine();
            Console.WriteLine("Dados do retangulo: "+ retangulo);
        }
    }
}
