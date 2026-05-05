using System;

namespace Calculando_as_medidas_de_um_triangulo_com_POO
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        //Método para calcular a área do triângulo

        public double Area()
        {
            double p = (A + B + C) / 2;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;
        }

    }
}
