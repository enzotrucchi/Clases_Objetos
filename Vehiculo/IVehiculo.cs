using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    internal interface IVehiculo
    {

        void Conducir();
        bool CargarCombustible(int combustible);
    }
}
