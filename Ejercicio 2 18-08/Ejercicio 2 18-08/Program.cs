using System;

namespace Ejercicio_2_18_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0, numero = 0;
            Console.WriteLine("Se iran ingresando hasta 10 numeros y se iran sumando, si la suma supera 50 no podra ingresar mas numeros ");
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine());
                suma += numero;
                if (suma >=50)
                {
                    break;
                }
            }
            Console.WriteLine("La suma total fue de: " + suma);

        }
    }
}
