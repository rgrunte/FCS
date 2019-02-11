using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majasdarbs_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //uzdevums2();
            //uzdevums3();
            //uzdevums5();
            //uzdevums6();
            uzdevums7();
            Console.ReadLine();
        }

        static void uzdevums1()
        {
            Console.Write("Ievadiet savu vecumu: ");
            int vecums = int.Parse(Console.ReadLine());
            if (vecums > 50)
                Console.WriteLine("Tu esi vecaks par 50");
            else
                Console.WriteLine("Tu esi jaunaks par  50");
        }

        static void uzdevums2()
        {
            Console.Write("Ievadiet skaitli: ");
            int sk = int.Parse(Console.ReadLine());
            if (sk < 50 && sk > -50)
                Console.WriteLine("Skaitlis ir starp -50 un 50");
            else
                Console.WriteLine("Skaitlis nav starp -50 un 50");
        }

        static void uzdevums3()
        {
            Console.Write("Ievadiet skaitli: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
                Console.WriteLine("Ievaditais skaitlis ir para skaitlis");
            else
                Console.WriteLine("Ievaditais skaitlis ir nepara skaitlis");

        }

        static void uzdevums4()
        {
            int sk1 = 5;
            int sk2 = 10;

            int min;

            if(sk1<sk2)
            {
                min = sk1;
            }
            else
            {
                min = sk2;
            }

            //int min1 = int.Math(sk1, sk2);
        }

        static void uzdevums5()
        {
            Console.Write("Ievadiet skaitlus: ");
            int N = int.Parse(Console.ReadLine());
            int summa = 0;
            while (N != 0)
            {
                summa += N % 10;
                N /= 10;
            }
            Console.Write("Ievadito skaitlu summa: {0}", summa);
        }

        static void uzdevums6()
        {
            int summa = 0;
            while (true)
            {
                Console.Write("ievadi skaitli: ");
                int sk = int.Parse(Console.ReadLine());

                if(sk == 13)
                {
                    break;
                }
                summa += sk % 10;
                sk /= 10;
            }

            Console.Write("Ievadito skaitlu summa: {0}", summa);
        }
        
        static void uzdevums7()
        {
            int skaitlis = 8;
            while(true)
            {
                Console.Write("uzmini skaitli no 1-10: ");
                int sk = int.Parse(Console.ReadLine());

                if(sk == skaitlis)
                {
                    break;
                }
            }
            Console.Write("Tu uzmineji {0}!", skaitlis);
        }

        /*static void uzdevums20()
        {
            n = 3
                n - r

                for(int r = 1; r <= n; r++)
            {
                for(int a = 1; a <= n - r; a++)
                {
                    Console
                }
            }
        }*/

    }
}
