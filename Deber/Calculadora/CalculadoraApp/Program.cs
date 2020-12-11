using System;
using LogicaCal;

namespace CalculadoraApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quiere usar la calculadora?");
            var respuesta = Console.ReadLine();

            while(respuesta != "no")
            {
                Console.WriteLine("Digite el nombre de la operación a realizar");
                Console.WriteLine("+");
                Console.WriteLine("-");
                Console.WriteLine("*");
                Console.WriteLine("/");
                Console.WriteLine("Inversa");
                Console.WriteLine("Cuadrado");
                Console.WriteLine("La raiz");

                var eleccion = Console.ReadLine();

                if (eleccion == "+")
                {
                    Console.WriteLine("Ingrese el primer número");
                    var numero1 = Console.ReadLine();
                    Console.WriteLine("Ingrese el segundo número");
                    var numero2 = Console.ReadLine();

                    var CalculadoraApp = new CalApp ();

                    var sumaTotal = CalculadoraApp.Sumar(int.Parse(numero1), int.Parse(numero2));

                    Console.WriteLine("El resultado de la suma es: " + sumaTotal);
                }
                if (eleccion == "-")
                {
                    Console.WriteLine("Ingrese el primer número");
                    var numero1 = Console.ReadLine();
                    Console.WriteLine("Ingrese el segundo número");
                    var numero2 = Console.ReadLine();

                    var CalculadoraApp = new CalApp();

                    var restaTotal = CalculadoraApp.Restar(int.Parse(numero1), int.Parse(numero2));

                    Console.WriteLine("El resultado de la resta es: " + restaTotal);
                }
                if (eleccion == "*")
                {
                    Console.WriteLine("Ingrese el primer número");
                    var numero1 = Console.ReadLine();
                    Console.WriteLine("Ingrese el segundo número");
                    var numero2 = Console.ReadLine();

                    var CalculadoraApp = new CalApp();

                    var multiTotal = CalculadoraApp.Multiplicar(int.Parse(numero1), int.Parse(numero2));

                    Console.WriteLine("El resultado de la multiplicaciòn es: " + multiTotal);

                }
                if(eleccion == "/")
                {
                    Console.WriteLine("Ingrese el primer número");
                    var numero1 = Console.ReadLine();

                    Console.WriteLine("Ingrese el segundo número");
                    var numero2 = Console.ReadLine();

                    var CalculadoraApp = new CalApp();

                    var residuo = CalculadoraApp.Dividir(int.Parse(numero1), int.Parse(numero2));

                    Console.WriteLine("El resultado de la division es: " + residuo);
                }
                if(eleccion == "Inversa")
                {
                    Console.WriteLine("Ingresa el numero que quieres ver su inversa");

                    var numero = Console.ReadLine();

                    var CalculadoraApp = new CalApp();

                    var inversa = CalculadoraApp.Inversa(double.Parse(numero));

                    Console.WriteLine("La inversa del número  " + numero + " es:  " + inversa);
                }
                if (eleccion == "Cuadrado")
                {
                    Console.WriteLine("Ingrese el número que quiere ver su cuadrado");

                    var numero = Console.ReadLine();

                    var CalculadoraApp = new CalApp();

                    var cuadrado = CalculadoraApp.Cuadrado(int.Parse(numero));

                    Console.WriteLine("El cuadrado del número " + numero + " es " + cuadrado);
                }
                if(eleccion == "La raiz")
                {
                    Console.WriteLine("Ingrese el número al que desea calcular su raíz cuadrada");

                    var numero = Console.ReadLine();

                    var CalculadoraApp = new CalApp();

                    var raiz = CalculadoraApp.Raiz(double.Parse(numero));

                    Console.WriteLine("La raíz del numero " + numero + " es " + raiz);
                }


                Console.WriteLine("Deseas volver a usar la calculadora?");
                respuesta = Console.ReadLine();
            }        

        }
    }
}
