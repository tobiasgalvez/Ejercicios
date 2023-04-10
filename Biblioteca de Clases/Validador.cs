using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public class Validador
    {
        public static bool ValidarRango(int valor, int min, int max)
        {
            if (valor < min || valor > max)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public static bool EsNumero(string valorString, out int valor)
        {
            int auxiliar = 0;
            bool retorno = !string.IsNullOrEmpty(valorString) && int.TryParse(valorString, out auxiliar);
            valor = auxiliar;
            return retorno;
        }


        public static int PedirNumeroValidado(int min, int max)
        {
            string? numeroString; //'?' para que el ReadLine no tire advertencia
            int numeroParseado;

            Console.WriteLine("Ingrese un numero:");
            numeroString = Console.ReadLine();
            while (!(int.TryParse(numeroString, out numeroParseado)) || !(Validador.ValidarRango(numeroParseado, min, max)))
            {
                Console.WriteLine("ERROR. ¡Reingresar número! :");
                numeroString = Console.ReadLine();
            }

            return numeroParseado;
        }


        public static string DeseaContinuar()
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


        public static bool ValidarRespuesta(string respuesta)
        {
            if (respuesta == "S")
            {
                return true;
            }
            else
            {

                return false;
            }

        }
    }
}
