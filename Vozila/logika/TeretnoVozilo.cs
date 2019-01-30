using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila.logika
{
    class TeretnoVozilo:Vozilo
    {
        private double masaTereta;
  
 
        public TeretnoVozilo(double masaTereta)
        {
            this.masaTereta = masaTereta;          
        }

        private double izracunajUkupnuMasu()
        {

            return MasaVozila + 95 + masaTereta;
        }


        public override string ToString()
        {
            return String.Format("Kamion-ukupna masa: {0}", izracunajUkupnuMasu());
        }


    }
}
