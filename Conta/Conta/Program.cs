using System;
using System.Drawing;

namespace Conta
{
    class Program
    {
        static void Main(string[] args)
        {
            string titular;
            int numeroconta;
            string resp;
            Console.WriteLine("Crie sua conta");
            Console.Write("Digite o numero da conta: ");
            numeroconta = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do titular: ");
            titular = Console.ReadLine();
            Conta c = new Conta(numeroconta, titular);
            Console.Write("Haverá deposito inicial?(s/n): ");
            resp = Console.ReadLine().ToLower();
            if (resp == "s")
            {
                Console.Write("Digite o Valor a Ser depositado: ");
                double valor = double.Parse(Console.ReadLine());
                c.AdicionarSaldo(valor);
            }

            Console.WriteLine("----Dados da Conta----");
            Console.WriteLine("Numero: " + c.NumeroConta);
            Console.WriteLine("Titular: "+ c.Titular);
            Console.WriteLine("Saldo: "+ c.Saldo);
            Console.WriteLine();
            Console.Write("Entre com o valor para deposito: ");
            double v = double.Parse(Console.ReadLine());
            c.AdicionarSaldo(v);
            Console.WriteLine("--------Atualizando...-----------");
            Console.WriteLine("----Dados da Conta----");
            Console.WriteLine("Numero: " + c.NumeroConta);
            Console.WriteLine("Titular: "+ c.Titular);
            Console.WriteLine("Saldo: "+ c.Saldo);
            Console.WriteLine();
            Console.Write("Digite o valor a ser sacado: ");
            double s = double.Parse(Console.ReadLine());
            c.Sacar(s);
            Console.WriteLine("--------Atualizando...-----------");
            Console.WriteLine("----Dados da Conta----");
            Console.WriteLine("Numero: " + c.NumeroConta);
            Console.WriteLine("Titular: "+ c.Titular);
            Console.WriteLine("Saldo: "+ c.Saldo);
            Console.WriteLine();


        }
    }
}
