using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3_Cikli
{
    class Program
    {
        static void Main(string[] args)
        {
            //CikluPiemers1();
            //uzdevums1();
            //uzdevums2();
            //uzdevums3();
            //uzdevums4();
            //uzdevums5();
            uzdevums6();

            Console.ReadLine();
        }
        static void CikluPiemers1()
        {
            Console.Write("Ievadi skaitli: ");
            int skaitlis = int.Parse(Console.ReadLine());

            for (int i = skaitlis; i <= 10; i++)
            {
                //pariet pie nakamas iteracijas (skaitla). Ciklu nepartrauc, bet izlaiz vienu iteraciju.
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);

                //lai patrauktu ciklu
                //if(i == 5)
                //{
                //    break;
                //}
            }

            Console.Write("Cikla beigas");
        }

        static void uzdevums1()
        {
            int summa = 0;
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
                summa = summa + 1;
                //summa += 1;
            }

            Console.WriteLine("Summa = {0}", summa);
        }

        static void uzdevums2()
        {
            Console.Write("Ievadiet dzimsanas gadu: ");
            int gads = int.Parse(Console.ReadLine());
            int robeza = DateTime.Now.Year;

            for (int i = gads; i <= robeza; i++)
                //otrs variants for (; gads <= robeza; gads++)
            {
                Console.WriteLine(i);
            }
            /* cits variants
            while(gads <= robeza)
            {
                Console.WriteLine(gads);
                gads = gads + 1;
                gads += 1;
                gads++;
            
            }
            */
        }

        static void uzdevums3()
        {
            Console.WriteLine("Ievadiet skaitli: ");
            int n = int.Parse(Console.ReadLine());
            int summa = 0;

            for (int i = 1; i <= n; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                    summa += 1;
                }
                /*
                 if (i % 2 != 0)
                 {
                 continue;
                 }
                 Console.WriteLine(i);
                 summa += 1;
                 */

                Console.WriteLine("Summa = {0}", summa);
            }
        }

        static void uzdevums4()
        {
            //1. lietotajs ievada skaitli N
            Console.WriteLine("Cik skaitlu ievadisi? ");
            int n = int.Parse(Console.ReadLine());
            //2. cikliski vaica ievadit N skaitlus
            int summa = 0;
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Ievadi {0}. skaitli", i);
                //int sk = int.Parse(Console.ReadLine());
                //summa = summa + sk;
                summa += int.Parse(Console.ReadLine());
            }
            //3. saskaita visus ievaditos skaitlus
            Console.WriteLine("Summa = {0}", summa);
            //4. ievadito skaitlu videja vertiba
            Console.WriteLine("Videja = {0}", summa / (float)n);
        }

        static void uzdevums5()
        {
            Console.Write("Ievadi skaitu: ");
            int N = int.Parse(Console.ReadLine());

            for (int rinda = 1; rinda <= N; rinda++)
            {
                for (int kollona= 1; kollona <= N; kollona++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }
        }

        static void uzdevums6()
        {
            Console.Write("Ievadi skaitli N: ");
            int N = int.Parse(Console.ReadLine());

            for (int rinda = 1; rinda <= N; rinda++)
            {
                for (int kolona = 1; kolona <= rinda; kolona++)
                {
                    Console.Write(kolona);
                }

                Console.WriteLine();
            }
            for (int rinda = N - 1; rinda >= 1; rinda--)
            {
                for (int kolona = 1; kolona <= rinda; kolona++)
                {
                    Console.Write(kolona);
                }
                Console.WriteLine();
            }
        }
    }
}
