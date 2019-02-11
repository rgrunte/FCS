using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4
{
    class Aplis
    {
        public string Krasa;
        public int Radiuss;

        public Aplis(int Radiuss, string Krasa)
        {
            this.Radiuss = Radiuss;
            this.Krasa = Krasa;
        }

        public void Laukums() //vai float
        {
            //return Radiuss * Radiuss * (float)3.14;
            Console.WriteLine("Apla Laukums = {0}", Math.PI * Radiuss * Radiuss);
        }

        public void Perimetrs() //vai float
        {
            //return 2 * (float)3.14 * Radiuss;
            Console.WriteLine("Apla perimters = {0}", 2 * Math.PI * Radiuss);
        }

        public void KrasasIzvade()
        {
            Console.WriteLine("Apla krasa ir {0}", Krasa);
        }

        /*public void KrasasIzvade()
        {
            Console.WriteLine("Krasa = {0}", Krasa);
        }*/
    }
}
