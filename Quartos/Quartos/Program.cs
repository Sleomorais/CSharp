namespace Quartos
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] vect = new Estudante[10];

            Console.Write("Digite o numero quartos a serem alugados: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Aluguel #{i}");
                Console.Write("Digite o nome do Aluno: ");
                string aluno = Console.ReadLine();
                Console.Write("Digite o email do Aluno: ");
                string email = Console.ReadLine();
                Console.Write("Escolha o numero do quarto de 0 a 10: ");
                int quarto= int.Parse(Console.ReadLine());
                vect[quarto] = new Estudante(aluno, email);
            }

            Console.WriteLine();
            Console.WriteLine("Ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if(vect[i] != null)
                {
                    Console.WriteLine(i+ " : "+ vect[i]);
                }
            }


        }
    }

}