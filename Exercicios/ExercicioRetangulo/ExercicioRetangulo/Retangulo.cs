using System;
using System.Globalization;

namespace ExercicioRetangulo
{
    class Retangulo
    {
        public double Altura;
        public double Largura;

        public double Area()
        {
            return Altura * Largura;
        }

        public double Perimetro()
        {
            return 2 * (Altura + Largura);
        }
        public double Diagonal()
        {
            return Math.Sqrt( Largura * Largura + Altura * Altura );
        }
        public override string ToString()
        {
            return "Altura: "
                + Altura
                + " Largura: "
                + Largura
                + " Área: "
                +  Area().ToString("F2", CultureInfo.InvariantCulture)
                + " Perimetro: "
                + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                + " Diagonal: "
                + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
