namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length);//Total de elementos
            Console.WriteLine(mat.Rank);// primeira dimensão da matriz
            Console.WriteLine(mat.GetLength(0));//quantidade na primeira dimensão
            Console.WriteLine(mat.GetLength(1));// quantidade na segunda dimensão

        }
    }
}
