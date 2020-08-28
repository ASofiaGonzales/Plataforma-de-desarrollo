using System;

namespace Ejercicio_1_18_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int edad = 1;
            string mensaje;
            Console.WriteLine("Ingrese su edad: ");
            string valor = Console.ReadLine();
            edad = int.Parse(valor);
            if (edad >= 1 && edad <= 4)
            {
                mensaje = "Te ganaste un sonojero";
            }
            else if (edad >=5 && edad <= 8)
            {
                mensaje = "Te ganaste una pelota";
            }
            else if (edad >=9 && edad <=18)
            {
                mensaje = "Te ganaste una bicicleta";
            }
            else if (edad >= 19 && edad <= 50 )
            {
                mensaje = "Te ganaste una orden de compra de $5000 en un supermercado";
            }
            else if (edad >= 51 && edad <= 100)
            {
                mensaje = "Te ganaste una orden de compra de $5000 en una farmacia";
            }
            else
            {
                mensaje = "Ganaste $10000";
            }
            Console.WriteLine(mensaje);
        }
    }
}