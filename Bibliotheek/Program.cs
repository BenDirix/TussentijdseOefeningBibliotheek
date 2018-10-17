using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal totaleWinst = 0.0m;
            Boek.Eigenaar = "VDAB";
            Genre thriller = new Genre("Thriller");
            thriller.Doelgroep = new Genre.Doelgroepen(18);
            Genre woordenboek = new Genre("Woordenboek");
            woordenboek.Doelgroep = new Genre.Doelgroepen(12);            

            IVoorwerpen[] voorwerpen = new IVoorwerpen[3];
            voorwerpen[0] = new BoekenRek(200, 50, 30.99m);
            voorwerpen[1] = new Leesboek("The Dark Tower", "Stephen King", 23.99m, thriller, "Fantasie met scherpschutters als hoofdpersoon");
            voorwerpen[2] = new Woordenboek("Van Dale", "Van Dale", 24.99m, woordenboek, "Nederlands");
            
            foreach (var voorwerp in voorwerpen)
            {
                voorwerp.GegevensTonen();
                totaleWinst += voorwerp.Winst;
            }
            Console.WriteLine($"\nTotale Winst: {totaleWinst:0.00}");
        }
    }
}
