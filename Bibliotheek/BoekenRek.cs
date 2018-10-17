using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek
{
    class BoekenRek : IVoorwerpen
    {
        public BoekenRek(int hoogte, int breedte, decimal aankoopprijs)
        {
            Hoogte = hoogte;
            Breedte = breedte;
            Aankoopprijs = aankoopprijs;
        }
        private int hoogteValue;
        public int Hoogte
        {
            get
            {
                return hoogteValue;
            }
            set
            {
                hoogteValue = value;
            }
        }
        private int breedteValue;
        public int Breedte
        {
            get
            {
                return breedteValue;
            }
            set
            {
                breedteValue = value;
            }
        }
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
        public decimal Winst
        {
            get
            {
                return Aankoopprijs * 2;
            }
        }

        public void GegevensTonen()
        {
            Console.WriteLine("BoekenRek:");
            Console.WriteLine($"Hoogte: {Hoogte}");
            Console.WriteLine($"Breedte: {Breedte}");
            Console.WriteLine($"Aankoopprijs: {Aankoopprijs}");
            Console.WriteLine($"Winst: {Winst}");
        }
    }
}
