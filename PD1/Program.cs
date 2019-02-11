using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uzdevums1();
            //uzdevums2();
            //uzdevums3();
            //uzdevums4();
            //uzdevums5();
            uzdevums6();
            Console.ReadLine();
        }

        static void Uzdevums1()
        {
            Console.Write("Ievadi skaitli: ");
            int sk = int.Parse(Console.ReadLine());
            if(sk % 3 == 0)
            {
                Console.WriteLine("Ievaditais skaitlis dalas ar 3");
            }
            else
            {
                Console.WriteLine("Ievaditais skaitlis nedalas ar 3");
            }
        }

        static void uzdevums2()
        {
            Console.Write("Ievadiet skaitli: ");
            int sk = int.Parse(Console.ReadLine());
            for(int i = sk; i >= 1; --i)
            {
                Console.WriteLine(i);
            }
            Console.Write("Cikla beigas!");
        }

        static void uzdevums3()
        {
            Console.Write("Ievadiet skaitli: ");
            int sk = int.Parse(Console.ReadLine());

            for(int i = 1; i <= sk; i++)
            {
                if (i == 5)
                {
                    continue;
                }

                Console.WriteLine(i);

                /* vai if(i != 5)
                 * {
                 * console.WriteLine(i)
                 * }
                 */
            }
        }

        static void uzdevums4()
        {
            Console.Write("Ievadiet nedelas dienu: ");

            string diena = Console.ReadLine();

            Console.Write("Vai esat atvalinajuma? ");

            string atvalinajums = Console.ReadLine();

            if(diena == "P" || diena == "O" || diena == "T" || diena == "C" || diena == "Pk")
            {
                if (atvalinajums == "N")
                {
                    Console.Write("7:00");
                }
                else if (atvalinajums == "J")
                {
                    Console.Write("10:00");
                }
            }
            else if (diena == "S" || diena == "Sv")
            {
                if(atvalinajums == "N")
                {
                    Console.Write("10:00");
                }
                else if(atvalinajums == "J")
                {
                    Console.Write("off");
                }
            }
            else
            {
                Console.Write("Ievaditi nepareizi dati");
            }
            /*switch
             * case"P"
             * case"O"
             * if(atvalinajums == "J")
             * {
             * Console.Write("10:00");
             * }
             * else
             * {
             * Console.Write("7:00");
             * }
             * 2.variants Console.Write(atvalinajums == "J" ? "10:00" : "7"00");
             * break;
             */
        }
        
        static void uzdevums5()
        {
            Console.Write("Ievadiet 1. skaitli: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Ievadiet 2. skaitli: ");
            int B = int.Parse(Console.ReadLine());

            if(B < A)
            {
                Console.WriteLine("Nekorektas vertibas!");
            }
            else
            {
                for (; A <= B; ++A)
                {
                    if (A % 3 == 0 && A % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (A % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else if (A % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else
                    {
                        Console.WriteLine(A);
                    }
                }
            }
        }

        static void uzdevums6()
        {
            Console.WriteLine("Pieejamas darbibas: ");
            Console.WriteLine("1 - Iemaksat");
            Console.WriteLine("2 - Pirkt");
            Console.WriteLine("3 - Sanemt atlikumu");
            Console.WriteLine("e - Partraukt");

            Automats automats = new Automats();

            while (true)
            {
                Console.Write("Ievadi darbibu: ");
                string darbiba = Console.ReadLine();
                switch(darbiba)
                {
                    case "e":
                        return;
                    case "1":
                        Console.Write("Ievadiet summu: ");
                        double summa = double.Parse(Console.ReadLine());
                        automats.Iemaksat(summa);
                        break;
                    case "2":
                        automats.PirktDzerienu();
                        break;
                    case "3":
                        automats.SanemtAtlikumu();
                        break;
                }
            }
        }

        static void uzdevums7()
        {
            //divi mainigie ar aka un *** un cikls strada tik ilgi kamer ir zvaigznites
        }
    }
}
