using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EjemploListaObjetos
{
    internal class Cromo
    {
        public enum categoriaCromo { Bronce, Plata,Oro};
        public int CodigoCromo {  get; set; }
        public string NombreCromo { get; set; }
        public categoriaCromo Categorias { get; set; }
    }
}
