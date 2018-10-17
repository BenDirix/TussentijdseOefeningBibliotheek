using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek
{
    class Genre
    {
        private Doelgroepen doelgroepValue;
        public Doelgroepen Doelgroep
        {
            get
            {
                return doelgroepValue;
            }
            set
            {
                doelgroepValue = value;
            }
        }
        public Genre(string naam)
        {
            Naam = naam;
        }
        private string naamValue;
        public string Naam
        {
            get
            {
                return naamValue;
            }
            set
            {
                if (value != string.Empty)
                    naamValue = value;
            }
        }

        public class Doelgroepen
        {
            public enum Categorieën
            {
                Jeugd,
                Volwassenen
            }
            public Doelgroepen(int leeftijd)
            {
                Leeftijd = leeftijd;
            }
            private int leeftijdValue;
            public int Leeftijd
            {
                get
                {
                    return leeftijdValue;
                }
                set
                {
                    if (value > 0)
                        leeftijdValue = value;
                }
            }
            private Categorieën categorieValue;
            public Categorieën Categorie
            {
                get
                {
                    if (Leeftijd >= 18)
                        return categorieValue = Categorieën.Volwassenen;
                    else
                        return categorieValue = Categorieën.Jeugd;
                }
            }
        }

        public void GegevensTonen()
        {
            Console.WriteLine($"Genre: {Naam}");
            Console.WriteLine($"Doelgroep: {Doelgroep.Categorie}");
        }
    }
}
