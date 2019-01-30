using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vozila.logika;

namespace Vozila
{
    class Program
    {
        private static List<Vozilo> vozila = new List<Vozilo>();


        static void Main(string[] args)
        {

            Autobus autobus = new Autobus(12);
            autobus.MasaVozila = 3478;        
            vozila.Add(autobus);

            Autobus autobus1 = new Autobus(12);
            autobus1.MasaVozila = 234;
            vozila.Add(autobus1);

            Autobus autobus2 = new Autobus(16);
            autobus2.MasaVozila = 544;
            vozila.Add(autobus2);

            TeretnoVozilo kamion = new TeretnoVozilo(123);
            kamion.MasaVozila = 732;
            vozila.Add(kamion);

            TeretnoVozilo kamion1 = new TeretnoVozilo(123);
            kamion1.MasaVozila = 5232;
            vozila.Add(kamion1);


            TeretnoVozilo kamion2 = new TeretnoVozilo(123);
            kamion2.MasaVozila = 5232;
            vozila.Add(kamion2);


            foreach (Vozilo voz in vozila)
            {
                
                if (voz.UkupnaMasaVozila() < 4500)
                { Console.WriteLine("Dozvoljen je prelazak mosta za vozilo:"+ voz.ToString()); }
                else { Console.WriteLine("Nije dozvoljen je prelazak mosta za vozilo:"+voz.ToString()); };
                           

            }

            Console.ReadLine();

        }
    }
}
