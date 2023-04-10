using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public class Boligrafo
    {
        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return color;
        }

        public short GetTinta()
        {
            return tinta;
        }

        private void SetTinta(short tinta)
        {
            int tintaAux = this.tinta;
            tintaAux = (short)(tintaAux + tinta);

            if(tintaAux >= 0 && tintaAux <= cantidadTintaMaxima)
            {
                this.tinta = (short)tintaAux;
            }
        }

        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            bool retorno = false;
            StringBuilder auxiliarDibujo = new StringBuilder(" ");
            SetTinta(gasto);
            if (GetTinta() > 0 && gasto > 0)
            {
                if (GetTinta() >= gasto)
                {
                    for (int i = 0; i < gasto; i++)
                    {
                        auxiliarDibujo.Append("*");
                    }
                    Console.ForegroundColor = GetColor();
                    retorno = true;
                }
            }
            dibujo = auxiliarDibujo.ToString();
            return retorno;

        }

    }
}
