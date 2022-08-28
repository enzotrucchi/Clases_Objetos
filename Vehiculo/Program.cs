namespace Vehiculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new(0);

            if (auto.CargarCombustible(1))
            {
                auto.Conducir();
            };
        }
    }
}