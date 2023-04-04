using Biblioteca_de_Clases;
using System.ComponentModel.Design;

namespace Ejercicio_I01___Creo_que_necesito_un_préstamo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string montoARetirarIngresadoString;
            float montoARetirarIngresadoParseado;

            string montoADepositarIngresadoString;
            float montoADepositarIngresadoParseado;

            int opcionIngresada;

            string seguir;

            Cuenta cuenta1 = new Cuenta("HolaBuenDia", (float)150000.75);

            do
            {
                Console.Clear();

                opcionIngresada = Menu();
                switch (opcionIngresada)
                {
                    case 1:
                        Console.WriteLine($"{cuenta1.Mostrar()}");
                        break;
                    case 2:
                        Console.WriteLine($"Saldo actual: {cuenta1.Cantidad}");
                        Console.WriteLine("Ingrese monto a depositar : ");
                        montoADepositarIngresadoString = Console.ReadLine();
                        while (!(float.TryParse(montoADepositarIngresadoString, out montoADepositarIngresadoParseado)))
                        {
                            Console.WriteLine("ERROR. ¡Reingrese monto! :");
                            montoARetirarIngresadoString = Console.ReadLine();

                        }
                        Console.WriteLine($"Saldo anterior: {cuenta1.Cantidad}");
                        cuenta1.Ingresar(montoADepositarIngresadoParseado);
                        Console.WriteLine($"Saldo actual: {cuenta1.Cantidad}");
                        break;

                    case 3:
                        Console.WriteLine($"Saldo actual: {cuenta1.Cantidad}");
                        Console.WriteLine("Ingrese monto a retirar: ");
                        montoARetirarIngresadoString = Console.ReadLine();
                        while (!(float.TryParse(montoARetirarIngresadoString, out montoARetirarIngresadoParseado)) ||!ValidarRangoFloat(montoARetirarIngresadoParseado, 1, cuenta1.Cantidad))
                        {
                            Console.WriteLine("ERROR. ¡Reingrese monto! :");
                            montoARetirarIngresadoString = Console.ReadLine();

                        }
                        Console.WriteLine($"Saldo anterior: {cuenta1.Cantidad}");
                        cuenta1.Retirar(montoARetirarIngresadoParseado);
                        Console.WriteLine($"Saldo actual: {cuenta1.Cantidad}");
                        break;

                }

              seguir = DeseaContinuar();

                } while (ValidarRespuesta(seguir));

            Console.WriteLine("Gracias por utilizar nuestro programa!!!");
        }


        private static int Menu()
        {
            string? opcionString;
            int opcionParseada;

            Console.WriteLine(
            "1.Mostrar datos de la cuenta\n" +
            "2.Ingresar monto para acreditar a la cuenta\n" +
            "3.Retirar monto para debitar de la cuenta\n" +
            "Ingrese una opcion:");
            opcionString = Console.ReadLine();
            while (!(int.TryParse(opcionString, out opcionParseada))||!ValidarRango(opcionParseada, 1, 3))
            {
                Console.WriteLine("ERROR. ¡Opcion Invalida! Reingrese :");
                opcionString = Console.ReadLine();
            }

            return opcionParseada;
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

        private static bool ValidarRango(int valor, int min, int max)
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

        private static bool ValidarRangoFloat(float valor, float min, float max)
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

        private static bool ValidarRespuesta(string respuesta)
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
    
