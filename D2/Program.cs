using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2
{
    class Program
    {
        static void Main(string[] args)
        {
            //uzdevums2();
            Console.ReadLine();
        }

        static void uzdevums1()
        {
            Console.Write("Ievadiet savu vecumu: ");
            int vecums = int.Parse(Console.ReadLine());

            //>=
            //<=
            //<
            //>
            //==
            //!=
            if (vecums > 18)
                Console.WriteLine("Tu esi pilngadigs");
            else if (vecums == 18)
                Console.WriteLine("Tev ir tiesi 18!");
            else
                Console.WriteLine("Tu esi nepilngadigs");
        }

        static void uzdevums2()
        {
            Console.Write("Ievadi 1.skaitli: ");
            int sk1 = int.Parse(Console.ReadLine());
            Console.Write("Ievadi 2.skaitli: ");
            int sk2 = int.Parse(Console.ReadLine());
            if (sk1 == sk2)
                Console.Write("Skaitli ir vienadi");
            else
                Console.Write("Skaitli nav vienadi");
            // var ari aizstat if else: 
            // Condition ? True : False
            // Console.Write(sk1 == sk2 ? "Skaitli ir vienadi" : "Skaitli nav vienadi");

            //if (sk1 == sk2 && sk1 == 5)
            //skaitli ir vienadi un sk1 ir 5

            //if sk1 == sk2 ll sk1 == 5)
            // skaitli ir vienadi vai sk1 ir 5
        }

        static void uzdevums3()
        {
            Console.Write("Ieraksti menesa pirmos tris burtus: ");
            string menesis = Console.ReadLine();
            menesis = menesis.ToLower();
            if (menesis == "apr" || menesis == "jun" || menesis == "sep" || menesis == "nov")
            {
                Console.Write("30 dienas");
            }
            else if (menesis == "feb")
            {
                Console.Write("28 dienas");­
            }
            else
            {
                Console.Write("31 diena");
            }

            //2.variants
            switch (menesis)
            {
                case "apr":
                case "jun":
                case "sep":
                case "nov":
                    Console.Write("30 dienas");
                    break;
                case "feb":
                    Console.Write("28 dienas");
                    break;
                default:
                    Console.Write("31 diena");
                    break;
            }
        }

        static void uzdevums4()
        {
            Console.Write("Ieraksti valsti: ");
            string valsts = Console.ReadLine();

            Console.Write("Valsts" + valsts + " galvaspilseta ir ");
            Console.Write("Valsts {0} galvaspilseta ir ", valsts);

            switch (valsts.ToLower())
            {
                case "igaunija":
                    Console.Write("Tallina");
                    break;
                case "somija":
                    Console.Write("Helsinki");
                    break;
                case "ukraina":
                    Console.Write("Kijeva");
                    break;
                case "zviedrija":
                    Console.Write("Stokholma");
                    break;
                case "krievija":
                    Console.Write("Maskava");
                    break;
                default:
                    Console.Write("Nezinama");
                    break;
            }
        }
    }
}
