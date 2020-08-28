using System;

namespace Ejercicio_25_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 8;
            string userinput = "";
            Console.WriteLine("Elegi un número del 1 al 20, ¿Pódras adivinarlo?");
            do
            {
                Console.WriteLine("Ingresa un numero");
                userinput = Console.ReadLine();

                if (x == int.Parse(userinput))
                {
                    Console.WriteLine("Muy bien! Ganaste");
                }
                else
                {
                    Console.WriteLine("Fallaste, intenta de nuevo\n");
                }
            }
            while (x != int.Parse(userinput));
            {
                Console.WriteLine("Juego terminado");
            }
        }
    }
}
