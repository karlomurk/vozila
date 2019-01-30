using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila.logika
{
    class Autobus:Vozilo
    {
        private double brojPutnika;
        
        public Autobus( double brojPutnika)
        {
            this.brojPutnika = brojPutnika;            
        }

        private double izracunajUkupnuMasuVozila()
        {
            return MasaVozila + (brojPutnika + 3) * 95;
        }

        public override double UkupnaMasaVozila()
        {
            return izracunajUkupnuMasuVozila();
        }

        public override string ToString()
        {
            return String.Format("Autobus-ukupna masa: {0}", izracunajUkupnuMasuVozila());
        }


    }
}
