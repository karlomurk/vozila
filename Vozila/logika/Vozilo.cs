using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila.logika
{
    public class Vozilo
    {

        public double MasaVozila { get; set; }

        public virtual double UkupnaMasaVozila()
            { return MasaVozila; }

    }

}
