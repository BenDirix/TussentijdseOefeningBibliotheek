using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek
{
    class Woordenboek: Boek
    {
        public Woordenboek(string titel, string auteur, decimal aankoopprijs, Genre genre, string taal) : base(titel, auteur, aankoopprijs, genre)
        {
            Taal = taal;
        }
        private string taalValue;
        public string Taal
        {
            get
            {
                return taalValue;
            }
            set
            {
                if (value != string.Empty)
                    taalValue = value;
            }
        }
        public override decimal Winst
        {
            get
            {
                return Aankoopprijs * 1.75m;
            }
        }
        public override void GegevensTonen()
        {
            Console.WriteLine("\nWoordenboek:");
            base.GegevensTonen();
            Console.WriteLine($"Taal: {Taal}");
        }
    }
}
