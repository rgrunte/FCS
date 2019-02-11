using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uzdevums21();
            Uzdevums22();
            Console.ReadLine();
        }

        static void Uzdevums21()
        {
            Kvadrats kv1 = new Kvadrats(5); //iekavas malas garums
            //kv1.malasGarums = 5; malas garums noteikts nerakstot iekavas

            int laukums = kv1.laukums();
            int perimetrs = kv1.perimetrs();

            Console.WriteLine("Laukums = {0}", laukums);
            Console.WriteLine("Perimetrs = {0}", perimetrs);

            Kvadrats kv2 = new Kvadrats(10);

            //Console.WriteLine("Laukums = {0}", kv2.laukums());
            //Console.WriteLine("Perimetrs = {0}", kv2.perimetrs());

            kv2.KonsolesIzvade();

            Kvadrats kv3 = new Kvadrats()
            {
                malasGarums = 3,
                //...

            };
            // tas pats, kas:
            // Kvadrats kv3 = new Kvadrats();
            // kv3.malasGarums = 3

            Kvadrats.FigurasNosaukums();

            Math.Round(5.1231233);
        }

        static void Uzdevums22()
        {
            Aplis a = new Aplis(4, "sarkana");
            //a.Krasa = "sarkans";

            a.Laukums();
            a.Perimetrs();
            a.KrasasIzvade();
        }

        static void Uzdevums23()
        {
            Darbinieks darbinieks = new Darbinieks
            {
                Vards = "Aigars",
                Uzvards = "Liepa",
                Dzivesvieta = new Adrese
                {
                    Valsts = "Latvija",
                    Pilseta = "Riga",
                    Iela = "Republikas laukums"
                },
                Darbavieta = new Adrese
                {
                    Valsts = "Latvija",
                    Pilseta = "Riga",
                    Iela = "Brivibas iela"
                }
            };

            darbinieks.Info();

        }
    }
}
