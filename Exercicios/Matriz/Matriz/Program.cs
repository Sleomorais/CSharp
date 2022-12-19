namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o numero de linhas: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Digite o numero de colunas: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.Write("Digite o numero que deseja buscar: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(mat[i, j] == x)
                    {
                        Console.WriteLine("Posição: "+ i +", "+j);
                        if (j>0)
                        {
                            Console.WriteLine("Esquerda: "+ mat[i,j-1]);
                        }
                        if (i>0)
                        {
                            Console.WriteLine("Em cima: "+ mat[i-1,j]);
                        }
                        if (j<n-1)
                        {
                            Console.WriteLine("Direita: "+ mat[i,j+1]);
                        }
                        if (i<n-1)
                        {
                            Console.WriteLine("Em Baixo: "+ mat[i+1,j]);
                        }
                    }
                }
            }

        }
    }
}
