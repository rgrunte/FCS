using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1_Uzdevumi
{
    class Program
    {
        static void Main(string[] args)
        {
            uzdevums6();

            Console.Read();
        }
        static void uzdevums2()
        {
            Console.Write("Ievadi 1. skaitli: ");
            int sk1 = int.Parse(Console.ReadLine());

            Console.Write("Ievadi 2. skaitli: ");
            int sk2 = int.Parse(Console.ReadLine());

            int summa = sk1 + sk2;
            int starpiba = sk1 - sk2;
            int reizinajums = sk1 * sk2;
            float dalijums = sk1 / (float)sk2;

            Console.WriteLine("Summa = " + summa);
            Console.WriteLine("Starpiba = " + starpiba);
            Console.WriteLine("Reizinajums = " + reizinajums);
            Console.WriteLine("Dalijums = " + dalijums);
        }
        static void uzdevums5()
        {
            Console.Write("Ievadi gradus pec Celsija = ");
            float sk1 = float.Parse(Console.ReadLine());

            // Izvade: gradi pec farenheita
            float farenheits = sk1 * 9/5 + 32;
            // Izvade: gradi pec kelvina
            float kelvins = sk1 + 273.15f;

            Console.WriteLine("Pec Farenheita = " + farenheits);
            Console.WriteLine("Pec Kelvina = " + kelvins);
        }
        static void uzdevums6()
        {
            Console.Write("Ievadi 1. skaitli: ");
            int sk1 = int.Parse(Console.ReadLine());

            Console.Write("Ievadi 2. skaitli: ");
            int sk2 = int.Parse(Console.ReadLine());

            Console.Write("Ievadi 3. skaitli: ");
            int sk3 = int.Parse(Console.ReadLine());

            Console.Write("Ievadi 4. skaitli: ");
            int sk4 = int.Parse(Console.ReadLine());

            float vid = (sk1 + sk2 + sk3 + sk4) / (float)4;

            Console.WriteLine("Videja vertiba = " + vid);
        }
    }
}
