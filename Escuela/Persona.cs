using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela
{
    internal class Persona
    {
        protected int edad;
        
        public void Saludar()
        {
            Console.WriteLine("Hola");
        }

        public void setearEdad(int edad)
        {
            this.edad = edad;
        }
    }
}
