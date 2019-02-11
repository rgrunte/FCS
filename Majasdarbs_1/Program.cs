using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majasdarbs_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // uzdevums1();
            // uzdevums2();
            // uzdevums3();
            // uzdevums4();
            uzdevums5();
            Console.Read();
        }

        static void uzdevums1()
        {
            Console.WriteLine("  *");
            Console.WriteLine(" ***");
            Console.WriteLine("*****");
        }

        static void uzdevums2()
        {
            Console.Write("Ievadi savu vardu: ");
            string vards = Console.ReadLine();

            Console.Write("Ievadi savu uzvardu: ");
            string uzvards = Console.ReadLine();

            Console.Write("Ievadi savu dzimto pilsetu: ");
            string pilseta = Console.ReadLine();

            Console.Write("Informacija: " + vards + "," + " " + uzvards + "," + " " + pilseta);
        }

        static void uzdevums3()
        {
            Console.Write("Ievadi vertibu: ");
            int a = int.Parse(Console.ReadLine());
            int d1 = a = a + 5;
            int d2 = a += 5;
            int d3 = a -= 3;
            int d4 = a *= 2;
            int d5 = a = a + 1;
            int d6 = a += 1;
            int d7 = a++;

            //a -=3 --> a = a - 3

            Console.WriteLine("1.darbiba = " + d1);
            Console.WriteLine("2.darbiba = " + d2);
            Console.WriteLine("3.darbiba = " + d3);
            Console.WriteLine("4.darbiba = " + d4);
            Console.WriteLine("5.darbiba = " + d5);
            Console.WriteLine("6.darbiba = " + d6);
            Console.WriteLine("7.darbiba = " + d7);
        }

        static void uzdevums4()
        {
            Console.Write("Ievadi vardu: ");
            string vards = (Console.ReadLine());
            //var ari viena rinda string vards = Console.ReadLine().ToUpper();
            string lielieburti = vards.ToUpper();
            Console.WriteLine("Jaunais vards: " + lielieburti);

        }

        static void uzdevums5()
        {
            Console.Write("Ievadiet savu vecumu: ");
            int vecums = int.Parse(Console.ReadLine());
            if (vecums > 18)
                Console.WriteLine("Tu esi pilngadigs");
            else
                Console.WriteLine("Tu esi nepilngadigs");
        }
    }
}
