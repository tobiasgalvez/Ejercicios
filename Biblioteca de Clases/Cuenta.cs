namespace Biblioteca_de_Clases
{
    public class Cuenta
    {
        private string titular;
        private float cantidad;

        public Cuenta(string titular, float cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string Titular { get => titular; }
        public float Cantidad { get => cantidad; }


        public string Mostrar()
        {
            return $"Razón social: {Titular}\nMonto actual de dinero en la cuenta:${Cantidad}";
        }

        public void Ingresar(float montoIngresado)
        {
            cantidad += montoIngresado;
        }

        public void Retirar(float montoParaDebitar)
        {
            cantidad -= montoParaDebitar;
        }
    }
}