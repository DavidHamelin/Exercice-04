using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string genre = "Monsieur";
            string nom = "Vincent";
            int visit = 1;

            Console.WriteLine($"Bonjour {genre} {nom}, vous êtes venu nous rendre visite {visit} fois !");
            Console.ReadKey();
        }
    }
}
