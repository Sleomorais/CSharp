using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> list2 = new List<string> { "Maria", "Alex" };
            List<string> list = new List<string>();
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            list.Insert(2, "Marco");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List count: "+ list.Count);

            //Primeiro item
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Resultado da pesquisa: " + s1);

            //Ultimo item
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Resultado da pesquisa: "+ s2);

            //Primeira posição
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira ocorrencia: " + pos1);

            //Ultima posição
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira ocorrencia: " + pos2);

            //Numero especifico de caracteres
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("-----------------");
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }

            //Remove um index especifico
            list.RemoveAt(2);
            Console.WriteLine("------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //Remove de um index especifico um total de posições
            list.RemoveRange(2,2);
            Console.WriteLine("------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //Remove um valor especifico da lista
            list.Remove("Alex");
            Console.WriteLine("------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            //Remover todas as ocorrencias de um valor especifico
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

        }
        //static bool Test(string s)
        //{
        //    return s[0] == 'A';
        //}
    }
}