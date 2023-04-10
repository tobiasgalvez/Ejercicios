using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;

namespace ClasesSobrecarga
{
    public class Sumador
    {
        private int _cantidadSumas;

        public Sumador(int cantidadSumas)
        {
            this._cantidadSumas = cantidadSumas;
        }

        public Sumador():this(0){
        }
        

        public static explicit operator int(Sumador s)
        {
            return s._cantidadSumas;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {

            return (long)(s1._cantidadSumas + s2._cantidadSumas);
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {

            return s1._cantidadSumas == s2._cantidadSumas;
        }

        public long Sumar(long a, long b)
        {
            _cantidadSumas++;
            return a + b;
        }

        public string Sumar(string a, string b)
        {
            _cantidadSumas++;
            return $"{a}{b}";
        }

    }
}