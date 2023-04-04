using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public class Estudiante
    {
        private int legajo;
        private string nombre;
        private string apellido;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            random = new Random();
        }
        public Estudiante(int legajo, string nombre, string apellido)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
        }


        public void SetNotaPrimerParcial(int nota)
        {
            notaPrimerParcial = nota;
        }

        public void SetNotaSegundoParcial(int nota)
        {
            notaSegundoParcial = nota;
        }

        private float CalcularPromedio()
        {
            return (float)(notaPrimerParcial + notaSegundoParcial) / 2;
        }

        public double CalcularNotaFinal()
        {
            if(notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                return random.Next(6,10);
            }
            return -1;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("============================================");
            sb.AppendLine(nombre);
            sb.AppendLine(apellido);
            sb.AppendLine(legajo.ToString());
            sb.AppendLine($"Nota primer parcial:{notaPrimerParcial}");
            sb.AppendLine($"Nota segundo parcial:{notaSegundoParcial}");
            sb.AppendLine($"Promedio: {CalcularPromedio()}");
            if (CalcularNotaFinal() != -1)
            {
                sb.AppendLine($"Nota final: {CalcularNotaFinal()}");
            }
            else
            {
                sb.AppendLine("Alumno desaprobado");
            }
            sb.AppendLine("=============================================");

            return sb.ToString();
        }


    }
}
