using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek
{
    class Leesboek : Boek
    {
        public Leesboek(string titel, string auteur, decimal aankoopprijs, Genre genre, string onderwerp):base(titel,auteur,aankoopprijs, genre)
        {
            Onderwerp = onderwerp;
        }
        private string onderwerpValue;
        public string Onderwerp
        {
            get
            {
                return onderwerpValue;
            }
            set
            {
                if (value != string.Empty)
                    onderwerpValue = value;
            }
        }
        public override decimal Winst
        {
            get
            {
                return Aankoopprijs * 1.5m;
            }
        }
        public override void GegevensTonen()
        {
            Console.WriteLine("\nLeesboek:");
            base.GegevensTonen();
            Console.WriteLine($"Onderwerp: {Onderwerp}");
        }
    }
}
