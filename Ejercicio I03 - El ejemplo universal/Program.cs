using Biblioteca_de_Clases;

namespace Ejercicio_I03___El_ejemplo_universal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante[] estudiantes = new Estudiante[3];

            estudiantes[0] = new Estudiante(1000, "Tobias", "Galvez");
            estudiantes[1] = new Estudiante(1001, "Nicolas", "Sanchez");
            estudiantes[2] = new Estudiante(1002, "Juan", "Perez");

            estudiantes[0].SetNotaPrimerParcial(10);
            estudiantes[0].SetNotaSegundoParcial(7);

            estudiantes[1].SetNotaPrimerParcial(4);
            estudiantes[1].SetNotaSegundoParcial(3);

            estudiantes[2].SetNotaPrimerParcial(4);
            estudiantes[2].SetNotaSegundoParcial(6);


           

            //foreach(Estudiante e in estudiantes)
            //{
            //    e.Mostrar();
            //    Console.WriteLine("hola");
            //}

            foreach (var estudiante in estudiantes)
            {
                Console.WriteLine(estudiante.Mostrar());
            }

        }
    }
}