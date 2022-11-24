using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Clovek
    {
        string jmeno;
        DateTime narozen;
        public Clovek(string jmeno, string narozen)
        {
            this.jmeno = jmeno;
            this.narozen = DateTime.Parse(narozen);
        }
        public void NastavJmeno(string jmeno)
        {
            this.jmeno = jmeno;
        }
        public string VypisJmeno()
        {
            return jmeno;
        }
        public double Vek()
        {
            TimeSpan result = DateTime.Now - narozen;
            return result.Days / 365.25;
        }
        public bool Plnolety()
        {
            if (Vek() >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }         
        }
        public string Starsi(Clovek dva)
        {
            if (dva.Vek() > this.Vek())
            {
                return dva.VypisJmeno() + " je starší než " + this.VypisJmeno();
            }
            else if(dva.Vek() < this.Vek())
            {
                return this.VypisJmeno() + " je starší než " + dva.VypisJmeno();
            }
            else
            {
                return this.VypisJmeno() + " je stejně starý jako " + dva.VypisJmeno();
            }
        }
        public override string ToString()
        {
            if(Plnolety() == true)
            {
                return this.VypisJmeno() + " má " + (int)Vek() + " a je plnoletý. ";
            }
            else
            {
                return this.VypisJmeno() + " má " + (int)Vek() + " a není plnoletý. ";
            }
            
        }
    }
}
