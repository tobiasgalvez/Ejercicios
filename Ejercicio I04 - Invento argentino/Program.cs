using Biblioteca_de_Clases;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;

namespace Ejercicio_I04___Invento_argentino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string seguir = "si";
            int opcionIngresada;
            int opcionIngresadaSubMenu;
            Boligrafo boligrafoAzul = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo boligrafoRojo = new Boligrafo(ConsoleColor.Red, 50);
            do
            {
                opcionIngresada = Menu();

                switch (opcionIngresada)
                {
                    case 1:
                            Console.Clear();
                        opcionIngresadaSubMenu = SubMenu();

                            switch (opcionIngresadaSubMenu)
                            {
                                case 1:
                                Console.Clear();
                                Console.WriteLine("Cantidad de astericos a dibujar(Mínimo 1, Máximo 100)");
                                string asteriscosDibujados;
                                int numerosDeAstericos = Validador.PedirNumeroValidado(1,100);
                                if (boligrafoAzul.Pintar((short)numerosDeAstericos, out asteriscosDibujados))
                                {
                                    Console.WriteLine(asteriscosDibujados);
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else if (boligrafoAzul.GetTinta() <= 0)
                                {
                                    Console.WriteLine("¡El boligrafo se quedo sin tinta!");
                                }
                                break;
                                case 2:
                                    Console.Clear();
                                    boligrafoAzul.Recargar();
                                    Console.WriteLine("¡El boligrafo se recargó!");
                                    break;

                            }
                        break;
                    case 2:

                        opcionIngresadaSubMenu = SubMenu();
                        switch (opcionIngresadaSubMenu)
                            {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Cantidad de astericos a dibujar(Mínimo 1, Máximo 50)");
                                string asteriscosDibujados;
                                int numerosDeAstericos = Validador.PedirNumeroValidado(1, 50);
                                if (boligrafoRojo.Pintar((short)numerosDeAstericos, out asteriscosDibujados))
                                {
                                    Console.WriteLine(asteriscosDibujados);
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else if (boligrafoRojo.GetTinta() <= 0)
                                {
                                    Console.WriteLine("¡El boligrafo se quedo sin tinta!");
                                }
                                break;
                            case 2:
                                Console.Clear();
                                boligrafoRojo.Recargar();
                                Console.WriteLine("¡El boligrafo se recargó!");
                                break;

                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Gracias por utilizar nuestro programa");
                        Environment.Exit(0);
                        seguir = "no";
                        break;
                }
            } while (seguir != "no");

        }


        private static int Menu()
        {
            string? opcionString;
            int opcionParseada;

            Console.WriteLine(
            "*****************MENU****************\n" +
            "1.Boligrafo azul\n" +
            "2.Boligrafo rojo\n" +
            "3.Salir\n" +
            "Ingrese una opcion:");
            opcionString = Console.ReadLine();
            while (!(int.TryParse(opcionString, out opcionParseada)) || !Validador.ValidarRango(opcionParseada, 1, 3))
            {
                Console.WriteLine("ERROR. ¡Opcion Invalida! Reingrese :");
                opcionString = Console.ReadLine();
            }

            return opcionParseada;
        }

        private static int SubMenu()
        {
            string? opcionString;
            int opcionParseada;

            Console.WriteLine(
            "*****************MENU****************\n" +
            "1.Dibujar asteriscos\n" +
            "2.Recargar\n" +
            "Ingrese una opcion:");
            opcionString = Console.ReadLine();
            while (!(int.TryParse(opcionString, out opcionParseada)) || !Validador.ValidarRango(opcionParseada, 1, 2))
            {
                Console.WriteLine("ERROR. ¡Opcion Invalida! Reingrese :");
                opcionString = Console.ReadLine();
            }

            return opcionParseada;
        }
    }
}