using Ejercicio_I01___Validador_de_rangos;
using System.ComponentModel.DataAnnotations;

internal class Program
{
    private static void Main(string[] args)
    {
        int numeroIngresado;
        int numeroMaximoIngresado = 0;
        int numeroMinimoIngresado = 0;
        int acumuladorNumerosIngresados = 0;
        float promedioDeNumerosIngresados = 0;


        for (int i = 0; i < 10; i++)
        {
            numeroIngresado = PedirNumeroValidado();

            if (i == 0 || numeroIngresado > numeroMaximoIngresado)
                numeroMaximoIngresado = numeroIngresado;

            if (i == 0 || numeroIngresado < numeroMinimoIngresado)
                numeroMinimoIngresado = numeroIngresado;

            acumuladorNumerosIngresados += numeroIngresado;


        }

        promedioDeNumerosIngresados = (float)acumuladorNumerosIngresados / 10;


        Console.WriteLine($"Valor minimo ingresado: {numeroMinimoIngresado}");
        Console.WriteLine($"Valor maximo ingresado: {numeroMaximoIngresado}");
        Console.WriteLine($"Promedio de numeros ingresados: {promedioDeNumerosIngresados}");

    }

    private static int PedirNumeroValidado()
    {
        string? numeroString; //'?' para que el ReadLine no tire advertencia
        int numeroParseado;

        Console.WriteLine("Ingrese un numero:");
        numeroString = Console.ReadLine();
        while (!(int.TryParse(numeroString, out numeroParseado)) || !(Validador.ValidarRango(numeroParseado, -100, 100)))
        {
            Console.WriteLine("ERROR. ¡Reingresar número! :");
            numeroString = Console.ReadLine();
        }

        return numeroParseado;
    }


}