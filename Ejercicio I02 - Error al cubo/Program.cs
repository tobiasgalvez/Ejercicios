using System;


/*Consigna
Ingresar un número y mostrar el cuadrado y el cubo del mismo. 
Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: 
"ERROR. ¡Reingresar número!".*/

namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresadoString;
            int numeroIngresadoParseado;


            Console.WriteLine("Ingrese un numero: ");
            numeroIngresadoString = Console.ReadLine();

            while ((int.TryParse(numeroIngresadoString, out numeroIngresadoParseado) != true) || numeroIngresadoParseado <= 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número! :");
                numeroIngresadoString = Console.ReadLine();

            }

            // Math.Pow(numero, 2);
            Console.WriteLine($"El cuadrado del numero '{numeroIngresadoParseado}' es: {Math.Pow(numeroIngresadoParseado, 2)}");
            //Math.Pow(numero, 3);
            Console.WriteLine($"El cubo del numero es: {Math.Pow(numeroIngresadoParseado, 3)}");

        }
    }
}