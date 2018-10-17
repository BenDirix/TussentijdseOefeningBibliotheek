using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek
{
    abstract class Boek : IVoorwerpen
    {
        public Boek(string titel, string auteur, decimal aankoopprijs, Genre genre)
        {
            Titel = titel;
            Auteur = auteur;
            Aankoopprijs = aankoopprijs;
            BoekGenre = genre;
        }
        private string titelValue;
        public string Titel
        {
            get
            {
                return titelValue;
            }
            set
            {
                if (value != string.Empty)
                    titelValue = value;
            }
        }
        private string auteurValue;
        public string Auteur
        {
            get
            {
                return auteurValue;
            }
            set
            {
                if (value != string.Empty)
                    auteurValue = value;
            }
        }
        public static string Eigenaar{ get; set; }
        private decimal aankoopprijsValue;
        public decimal Aankoopprijs
        {
            get
            {
                return aankoopprijsValue;
            }
            set
            {
                aankoopprijsValue = value;
            }
        }
        private Genre genreValue;
        public Genre BoekGenre
        {
            get
            {
                return genreValue;
            }
            set
            {
                genreValue = value;
            }
        }

        public abstract decimal Winst
        {
            get;
        }

        public virtual void GegevensTonen()
        {
            Console.WriteLine($"Titel: {Titel}");
            Console.WriteLine($"Auteur: {Auteur}");
            Console.WriteLine($"Eigenaar: {Eigenaar}");
            Console.WriteLine($"Aankoopprijs: {Aankoopprijs}");
            Console.WriteLine($"Winst: {Winst:0.00}");
            BoekGenre.GegevensTonen();
        }
    }
}
