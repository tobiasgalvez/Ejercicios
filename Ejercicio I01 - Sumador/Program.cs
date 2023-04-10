using ClasesSobrecarga;

namespace Ejercicio_I01___Sumador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador suma = new Sumador();
            Sumador suma2 = new Sumador(1);

            long a = 10;
            long b = 20;

            long c = 30;
            long d = 40;

            string num1 = "hola";
            string num2 = "chau";

            Console.WriteLine(suma.Sumar(a, b));
            Console.WriteLine(suma2.Sumar(num1, num2));
            Console.WriteLine(suma.Sumar(c, d));

            Console.WriteLine(suma|suma2);
            Console.WriteLine(suma+suma2);

            //suma.Sumar(a, b);
            //suma2.Sumar(num1, num2);



        }
    }
}