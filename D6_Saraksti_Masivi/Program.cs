using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6_Saraksti_Masivi
{
    class Program
    {
        static void Main(string[] args)
        {
            //piemers();
            //uzdevums2();
            uzdevums3();

            Console.ReadLine();
        }

        static void piemers()
        {
            int sk1;
            int sk2;

            int[] skaitli = new int[5]; //masīvs ar 5 elementiem - int
            skaitli[0] = 1;
            skaitli[1] = 2;
            skaitli[2] = 3;
            skaitli[3] = 4;
            skaitli[4] = 5;
            //namaka rinda izmetis kludu - IndexOutOfRange. Jo mums ir tikai 5 pozicijas no 0  lidz 4 ieskaitot
            //skaitli[5] = 6;

            int skaitlis = skaitli[3]; // 4

            for(int i = 0; i <= skaitli.Length; i++) //lai izrakstitu visas vienibas masiva
            {
                Console.WriteLine(skaitli[i]);

                /* int vertiba = skaitli[i];
                 * Console.WriteLine(vertiba);
                 */
            }
            //foreach (... in masivs)
            foreach(int vertiba in skaitli)
            {
                Console.WriteLine(vertiba);
            }
        }

        static void uzdevums1()
        {
            Console.Write("Ievadi skaitli: ");
            int N = int.Parse(Console.ReadLine());
            int[] masivs = { 0, 10, 20, 30, 40, 50 };

        bool irAtrasts = false;
        for(int i = 0; i < masivs.Length; i++)
            {
                if (masivs[i] == N)
                {
                    Console.WriteLine("Skaitlis ir atrasts pozicija {0}", i);
                    irAtrasts = true;
                    break;
                }
            }

            if (irAtrasts == false)
                //2.variants if(!irAtrasts) izsaukumzime nozime - nav 
            {
                Console.WriteLine("skaitlis nav masiva!");
            }
        }

        static void uzdevums2()
        {

            /*Console.Write("Ievadi 1.skatili: ");
            int sk1 = int.Parse(Console.ReadLine());
            Console.Write("Ievadi 2.skatili: ");
            int sk2 = int.Parse(Console.ReadLine());
            Console.Write("Ievadi 3.skatili: ");
            int sk3 = int.Parse(Console.ReadLine());
            Console.Write("Ievadi 4.skatili: ");
            int sk4 = int.Parse(Console.ReadLine());
            Console.Write("Ievadi 5.skatili: ");
            int sk5 = int.Parse(Console.ReadLine());

            int[] masivs = { sk1, sk2, sk3, sk4, sk5 };
            */
            // ievade

            int[] masivs = new int[5];

            for (int i = 0; i < masivs.Length; i++)
            {
                Console.Write("Ievadi skatili: ");
                masivs[i] = int.Parse(Console.ReadLine());
            }

            //izvade
            for(int i = masivs.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(masivs[i]);
            }
        }

        static void saraksts()
        {
            List<int> saraksts = new List<int>();
            //for(int i = 1; i <= 5; i++)
            while (true)
            {
                Console.Write("Ievadi skaitli (vai 0, lai partrauktu): ");
                string vertiba = Console.ReadLine();
                if(string.IsNullOrEmpty(vertiba))
                {
                    break;
                }
                int skaitlis = int.Parse(vertiba);
                if(skaitlis == 0)
                {
                    break;
                }
                saraksts.Add(skaitlis);
            }
            //int elementuSkaits = saraksts.Count;
            saraksts.Reverse();
            Console.WriteLine(String.Join(", ", saraksts));
        }

        static void uzdevums3()
        {
            List<int> saraksts = new List<int>();
            //Ievade
            while (true)
            {
                Console.Write("Ievadi skaitli (vai 0, lai partrauktu): ");
                string vertiba = Console.ReadLine();
                if (string.IsNullOrEmpty(vertiba))
                {
                    break;
                }
                int skaitlis = int.Parse(vertiba);
                if (skaitlis == 0)
                {
                    break;
                }
            }

            //Skaitisana
            //1. variants
            int skaits = 0;
            foreach(int skaitlis in saraksts)
            {
                if(skaitlis == 5)
                {
                    skaits++;
                    //skaits += 1;
                    //skaits = skaits += 1;
                }
            }
            Console.WriteLine("Skaitlis 5 atrasts {0} reizes", skaits);

            //2. variants
            skaits = saraksts.Count(skaitlis => skaitlis == 5);
            Console.WriteLine("Skaitlis 5 atrasts {0} reizes", skaits);
        }
    }
}
