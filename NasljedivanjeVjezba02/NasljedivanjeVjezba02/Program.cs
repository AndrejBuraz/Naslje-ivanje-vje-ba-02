using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasljedivanjeVjezba02
{
    class NebeskoTijelo
    {
        public double BrzinaOkoOsi, BrzinaOkoSunca;
        public override string ToString()
        {
            string ispis= ("Brzina oko Osi: " + this.BrzinaOkoOsi + " \nBrzina oko sunca: " + this.BrzinaOkoSunca);
            return ispis;
        }
    }
    class Planet : NebeskoTijelo
    {
        public Planet(double BrzinaOkoOsi, double BrzinaOkoSunca)
        {
            this.BrzinaOkoSunca = BrzinaOkoSunca;
            this.BrzinaOkoOsi = BrzinaOkoOsi;
        }
    }
    class Satelit : NebeskoTijelo
    {
        public Satelit(double BrzinaOkoOsi, double BrzinaOkoSunca)
        {
            this.BrzinaOkoSunca = BrzinaOkoSunca;
            this.BrzinaOkoOsi = BrzinaOkoOsi;
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Planet Zemlja = new Planet(5.5, 2.5);
            Satelit Mjesec = new Satelit(10.5, 15.5);
            Console.WriteLine("Zemlja: " + Zemlja.ToString());
            Console.WriteLine("Mjesec: " + Mjesec.ToString());
            Console.ReadKey();
        }
    }
}
