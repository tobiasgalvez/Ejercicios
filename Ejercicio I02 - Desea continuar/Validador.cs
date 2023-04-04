using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I02___Desea_continuar
{
    internal class Validador
    {

        internal static bool ValidarRespuesta(string respuesta)
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
