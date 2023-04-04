using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private int dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
        public int Dni { get => dni; set => dni = value; }



        private int CalcularEdad()
        {
            int edad;
            return edad = DateTime.Today.AddTicks(-FechaDeNacimiento.Ticks).Year - 1;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre:{Nombre}");
            sb.AppendLine($"Dni: {Dni.ToString()}");
            sb.AppendLine($"Edad {CalcularEdad().ToString()}");
            return sb.ToString();
        }

        public string EsMayorDeEdad()
        {
            int edad = CalcularEdad();
            if (edad >= 18)
            {
                return "es mayor de edad";
            }
            return "es menor de edad";
        }
    }
}
