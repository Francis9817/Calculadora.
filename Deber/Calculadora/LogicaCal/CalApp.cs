using System;

namespace LogicaCal
{
    public class CalApp
    {
        public int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
        public int Restar(int numero1, int numero2)
        {
            return numero1 - numero2;
        }
        public int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        public int Dividir(int numero1, int numero2)
        {
            return numero1 / numero2;
        }

        public double Inversa(double numero)
        {
            return 1 / numero;
        }

        public int Cuadrado(int numero)
        {

            return numero * numero;
        }

        public double Raiz(double numero)
        {
            return Math.Sqrt(numero);
        }
    }
}
