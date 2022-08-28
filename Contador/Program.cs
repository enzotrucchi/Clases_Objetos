namespace Contador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contador contador = new(10);
            contador.Incrementar();
            contador.Incrementar();
            contador.ImprimirValorActual();
            contador.Decrementar();
            contador.ImprimirValorActual();
        }
    }
}