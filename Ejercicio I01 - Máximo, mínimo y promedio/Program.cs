using System;

namespace Ejercicio_01
{
    internal class Program
    {

        /*
         Consigna
        Ingresar 5 números por consola, guardándolos en una variable escalar. 
        Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.*/


        static void Main(string[] args)
        {
            string numeroIngresadoString;
            int numeroIngresadoParseado = 0;
            bool resultadoDelParseo;

            int maximoDeNumerosIngresados = 0;
            int minimoDeNumerosIngresados = 0;

            int acumuladorDeNumerosIngresados = 0;

            float promedioNumerosIngresados = 0f;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                numeroIngresadoString = Console.ReadLine();
                resultadoDelParseo = int.TryParse(numeroIngresadoString, out numeroIngresadoParseado);

                if (resultadoDelParseo == true)
                {
                    acumuladorDeNumerosIngresados += numeroIngresadoParseado;

                    if (i == 0)
                    {
                        minimoDeNumerosIngresados = numeroIngresadoParseado;
                        maximoDeNumerosIngresados = numeroIngresadoParseado;
                    }
                    else
                    {
                        if (maximoDeNumerosIngresados < numeroIngresadoParseado)
                        {
                            maximoDeNumerosIngresados = numeroIngresadoParseado;
                        }
                        if (minimoDeNumerosIngresados > numeroIngresadoParseado)
                        {
                            minimoDeNumerosIngresados = numeroIngresadoParseado;
                        }
                    }
                }
            }

            promedioNumerosIngresados = (float)(acumuladorDeNumerosIngresados / 5);

            Console.WriteLine($"Valor máximo = {maximoDeNumerosIngresados} --- Valor mínimo = {minimoDeNumerosIngresados} --- Promedio = {promedioNumerosIngresados} ");
            //Console.WriteLine($"Valor mínimo = {min}");
            //Console.WriteLine($"Promedio ={promedio}");

        }
    }
}