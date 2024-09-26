using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EjemploListaObjetos
{
    internal class Cromo
    {
        public enum CategoriaCromo { Bronce, Plata,Oro};
        public int CodigoCromo {  get; set; }
        public string NombreCromo { get; set; }
        public CategoriaCromo Categorias { get; set; }

        public Cromo (int codigoCromo, string nombreCromo, CategoriaCromo categorias)
        {
            CodigoCromo = codigoCromo;
            NombreCromo = nombreCromo;
            Categorias = categorias;
        }

        public Cromo() { }
    }
}
