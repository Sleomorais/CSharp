using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta
{
    class Conta
    {
        public int NumeroConta { get; private set; }
        public string Titular { get; private set; }
        private double _saldo;

        public Conta(int num, string titular)
        {
            NumeroConta = num;
            Titular = titular;
        }
        public double Saldo
        {
            get { return _saldo; }
            set
            {
                if(value != 0.00 && value >= 0.01)
                {
                    _saldo = value;
                }
                else
                {
                    _saldo = 0.00;
                }
            }
        }
        public void AdicionarSaldo(double valor)
        {
            _saldo += valor;
        }
        public void Sacar(double valor)
        {
            if (_saldo >= valor)
            {
                double desconto = 5.00;
                _saldo = (_saldo - desconto) - valor;
            }
            else
            {
                Console.WriteLine("Saque Indisponivel"); ;
            }
        }
    }
}
