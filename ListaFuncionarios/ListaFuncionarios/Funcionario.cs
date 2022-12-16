using System;
using System.Globalization;

namespace ListaFuncionarios
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }


        public Funcionario(int id, string name, double salario)
        {
            Id=id;
            Nome=name;
            Salario=salario;
        }

        public void IncrementarSalario(double porcentagem)
        {
            Salario += Salario * porcentagem / 100.0;
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Nome
                + ", "
                + Salario.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
