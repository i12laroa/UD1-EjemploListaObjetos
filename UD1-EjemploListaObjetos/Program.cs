using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EjemploListaObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cromo> listaCromos = new List<Cromo>();

            Cromo cromo1 = new Cromo();
            cromo1.CodigoCromo = 1;
            cromo1.NombreCromo = "Pokemon1";
            cromo1.Categorias = Cromo.categoriaCromo.Oro;

            listaCromos.Add(cromo1);

            Cromo cromo2 = new Cromo();
            cromo2.CodigoCromo = 2;
            cromo2.NombreCromo = "Aqua5";
            cromo2.Categorias = Cromo.categoriaCromo.Plata;

            listaCromos.Add(cromo2);

            foreach(Cromo cromo in listaCromos)
            {
                Console.WriteLine("Código del cromo: " +cromo.CodigoCromo+ " Nombre: "+cromo.NombreCromo);
            }

            listaCromos.Remove(cromo2);

            foreach (Cromo cromo in listaCromos)
            {
                Console.WriteLine("Código del cromo: " + cromo.CodigoCromo + " Nombre: " + cromo.NombreCromo);
            }

        }
    }
}
