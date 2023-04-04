using Ejercicio_I02___Desea_continuar;

internal class Program
{
    private static void Main(string[] args)
    {
        int numeroIngresado;
        string seguir;

        do
        {
            numeroIngresado = PedirNumeroValidado();

            seguir = DeseaContinuar();


        } while (Validador.ValidarRespuesta(seguir));
    }


    private static int PedirNumeroValidado()
    {
        string? numeroString; //'?' para que el ReadLine no tire advertencia
        int numeroParseado;

        Console.WriteLine("Ingrese un numero:");
        numeroString = Console.ReadLine();
        while (!(int.TryParse(numeroString, out numeroParseado)))
        {
            Console.WriteLine("ERROR. ¡Reingresar número! :");
            numeroString = Console.ReadLine();
        }

        return numeroParseado;
    }

    private static string DeseaContinuar()
    {
        string? seguir;

        Console.WriteLine("¿Desea continuar? (S/N): ");
        seguir = Console.ReadLine();
        seguir = seguir.ToUpper();

        while (seguir != "S" && seguir != "N")
        {
            Console.WriteLine("ERROR. Ingrese (S/N): ");
            seguir = Console.ReadLine();
            seguir = seguir.ToUpper();
        }

        return seguir;

    }

}