using System;
using System.IO;

namespace ExercicioUrna
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o Caminho do arquivo dos votos: ");
            string path = Console.ReadLine();

            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    Dictionary<string,int> dic = new Dictionary<string,int>();
                    while (!sr.EndOfStream)
                    {
                        string[] historicoVotos = sr.ReadLine().Split(',');
                        string candidato = historicoVotos[0];
                        int votos = int.Parse(historicoVotos[1]);

                        if (dic.ContainsKey(candidato))
                        {
                            dic[candidato] += votos;
                        }
                        else
                        {
                            dic[candidato] = votos;
                        }
                    }

                    foreach(var item in dic)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Ocorreu um erro");
                Console.WriteLine(e.Message);
            }
        }
    }
}
