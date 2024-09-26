using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EjemploListaObjetos
{
    internal class Program
    {
        static List<Cromo> listaCromos = new List<Cromo>();

        static void Main(string[] args)
        {
            List<Cromo> listaAuxiliar = new List<Cromo>()
            {
                  new Cromo(20, "Cromo20", Cromo.CategoriaCromo.Plata),
                  new Cromo(30, "Cromo30", Cromo.CategoriaCromo.Plata)
            }; 


            Cromo cromo1 = new Cromo(1, "Pokemon1", Cromo.CategoriaCromo.Plata);
            //cromo1.CodigoCromo = 1;
            //cromo1.NombreCromo = "Pokemon1";
            //cromo1.Categorias = Cromo.CategoriaCromo.Oro;

            listaCromos.Add(cromo1);

            Cromo cromo2 = new Cromo();
            cromo2.CodigoCromo = 2;
            cromo2.NombreCromo = "Aqua5";
            cromo2.Categorias = Cromo.CategoriaCromo.Plata;

            listaCromos.Add(cromo2);

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("LISTA DE CROMOS INICIAL");

            RecorrerListaCromos();

            listaCromos.Remove(cromo2);
           
            listaCromos.AddRange(listaAuxiliar);

            bool existeCromo = listaCromos.Contains(cromo1);

            Console.WriteLine(existeCromo);

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("LISTA DE CROMOS FINAL");

            RecorrerListaCromos();

            Console.ResetColor(); 
        }

        static private void RecorrerListaCromos()
        {
            foreach (Cromo cromo in listaCromos)
            {
                Console.WriteLine("Código del cromo: " + cromo.CodigoCromo + " Nombre: " + cromo.NombreCromo);
            }
        }
    }
}
