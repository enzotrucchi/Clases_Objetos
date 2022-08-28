using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contador
{
    internal class Contador
    {
        private int valorActual = 0;
        
        public Contador(int valor)
        {
            this.valorActual = valor;
        }
        
        public void Incrementar()
        {
            this.valorActual++;
        }

        public void Decrementar()
        {
            this.valorActual--;
        }

        public void ImprimirValorActual()
        {
            Console.WriteLine(this.valorActual);
        }
    }
}
