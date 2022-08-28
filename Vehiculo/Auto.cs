using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    internal class Auto : IVehiculo
    {
        public int Combustible {get; set;}
    
        public Auto(int combustible)
        {
            Combustible = combustible;
        }

        public void Conducir()
        {
            while (Combustible > 0)
            {
                Console.WriteLine("Conduciendo");
                Combustible--;
            };

            Console.WriteLine("No hay combustible");
        }

        public bool CargarCombustible(int combustible)
        {
            Console.WriteLine("Cargando...");
            Combustible += combustible;
            return true;
        }
    }
}
