using Biblioteca_de_Clases;

namespace Ejercicio_I02___Vos_cuántas_primaveras_tenés
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona[] personas = new Persona[3];

            personas[0] = new Persona("Tobias", new DateTime(2002,10,10), 44521134);
            personas[1] = new Persona("Lola", new DateTime(2009,1,12), 56754432);
            personas[2] = new Persona("Chantal", new DateTime(2000,4,17), 42543231);

            for (int i = 0; i < personas.Length; i++)
            {
                Console.WriteLine($"{personas[i].Nombre} {personas[i].EsMayorDeEdad()}");

            }

            Console.WriteLine("Datos de las personas");
            for (int i = 0; i < personas.Length; i++)
            {
                Console.WriteLine($"{personas[i].Mostrar()}");
            }
        }
    }
}