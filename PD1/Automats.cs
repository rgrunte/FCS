using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD1
{
    class Automats
    {
        private double IemaksataSumma;

        public Automats()
        {
            IemaksataSumma = 0;
        }

        public void Iemaksat(double summa)
        {
            IemaksataSumma += summa;
            Console.WriteLine("Atlikums: EUR {0}", IemaksataSumma);
        }

        public void PirktDzerienu()
        {
            if(IemaksataSumma >= 0.8)
            {
                IemaksataSumma -= 0.8;
                Console.WriteLine("Iegadats Atlikums: EUR {0}", + IemaksataSumma);
            }
            else
            {
                Console.WriteLine("Nepietiek lidzeklu!");
            }
        }

        public void SanemtAtlikumu()
        {
            Console.WriteLine("Tu sanemi: EUR {0}", IemaksataSumma);
            IemaksataSumma = 0;
        }

    }
}
