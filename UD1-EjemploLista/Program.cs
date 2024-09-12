using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EjemploLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList cromos = new ArrayList();
            string[] cartas = new string[] { "Dinosuar45", "Star56", "Luthor67" };

            Console.WriteLine("Vamos a crear una baraja de cromos de Pokemon");
            cromos.Add("Digimon1");
            cromos.Add("wesker");
            cromos.AddRange(cartas);

            foreach (string s in cromos)
            {
                Console.WriteLine(s);
            }

        }
    }
}
