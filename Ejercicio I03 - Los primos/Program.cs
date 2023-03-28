using System;

namespace Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresadoString;
            int numeroIngresadoParseado;
            // int auxiliar = 2;
            string seguir;

            do
            {

                Console.WriteLine("Ingrese un numero: ");
                numeroIngresadoString = Console.ReadLine();

                while ((int.TryParse(numeroIngresadoString, out numeroIngresadoParseado) != true) || numeroIngresadoParseado <= 0)
                {
                    Console.WriteLine("ERROR. ¡Reingresar número! :");
                    numeroIngresadoString = Console.ReadLine();

                }

                Console.WriteLine($"Los numeros primos que hay hasta el número que ingresó ({numeroIngresadoParseado}) son:");

                for (int i = 2; i <= numeroIngresadoParseado; i++)
                {
                    if (EsPrimo(i) == true)
                    {
                        Console.WriteLine($"{i}");
                    }
                }
                Console.WriteLine("Desea seguir ingresando numeros? (si/salir):");
                seguir = Console.ReadLine();
                while (seguir != "si" && seguir != "salir")
                {
                    Console.WriteLine("ERROR. Ingrese si/salir: ");
                    seguir = Console.ReadLine();

                }


            } while (seguir == "si");

            Environment.Exit(0);


        }

        static bool EsPrimo(int numero)
        {
            for (int j = 2; j < numero; j++)
            {
                if ((numero % j) == 0)//no es primo porque tiene mas numeros divisores
                {
                    return false;
                }

            }

            return true;
        }
    }
}
