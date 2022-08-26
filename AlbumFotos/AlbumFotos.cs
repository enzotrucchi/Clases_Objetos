using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumFotos
{
    internal class AlbumFotos
    {
        protected int numeroDePaginas;

        public AlbumFotos()
        {
            this.numeroDePaginas = 16;
        }

        public AlbumFotos(int numeroDePaginas)
        {
            this.numeroDePaginas = numeroDePaginas;
        }

        //? Opción 1: Común
        //public int NumeroDePaginas
        //{
        //    get
        //    {
        //        return this.numeroDePaginas;
        //    }

        //    set
        //    {
        //        numeroDePaginas = value;
        //    }
        //}

        //? Opción 2: Usando => operator
        //! https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-operator
        public int NumeroDePaginas
        {
            get => numeroDePaginas;
            set => numeroDePaginas = value;
        }

        //? Opción 3: Usando short hand properties y lambda
        //public int NumeroDePaginas => numeroDePaginas;

        //? Opción 4: Usando short hand properties
        //public int NumeroDePaginas { get; set; }



    }
}
