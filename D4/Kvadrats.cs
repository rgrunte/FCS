using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4
{
    class Kvadrats
    {
        //ipasiba
        public int malasGarums;

        //Konstruktors
        public Kvadrats(int mala)
        {
            malasGarums = mala;

            //ja knostruktora izmanto tadu pasu nosaukumu ka
            //ipasibu tad prieksa var likt this (this versas pie objekta)
            //public Kvadrats(int malasGarums)
            //this.malasGarums = malasGarums
        }

        public Kvadrats()
        {

        }

        //funkcija
        public int laukums()
        {
            return malasGarums * malasGarums;
        }
        // funkcija int atgriez (return), vertiba return tiek glabata atmina. Nevar atstat tuksu. Sanemt vertibas no objekta
        public int perimetrs()
        {
            return malasGarums * 4;
        }
        // funkcija void neko neatgriez tikai izvada (void tiek izmantots int vieta, lai optimizetu atminu)
        public void KonsolesIzvade()
        {
            Console.WriteLine("Perimetrs = {0}", perimetrs());
            Console.WriteLine("Laukums = {0}", laukums());
        }

        public static void FigurasNosaukums() //ja mes versamies pie pasas klases
        {
            Console.WriteLine("Sis ir Kvadrats!");
        }
    }
}
