using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2_Papildus_uzdevumi
{
    class Program
    {
        static void Main(string[] args)
        {
            uzdevums2();
            Console.Read();
        }
        static void uzdevums1()
        {
            Console.Write("Ievadi veicamo operaciju: ");
            string zime = Console.ReadLine();
            Console.Write("Ievadi 1.skaitli: ");
            int sk1 = int.Parse(Console.ReadLine());
            Console.Write("Ievadi 2.skaitli: ");
            int sk2 = int.Parse(Console.ReadLine());
            if (zime == "*")
            {
                int darbiba1 = sk1 * sk2;
                Console.Write("Rezutats: " + darbiba1);
            }
            else if (zime == "/")
            {
                int darbiba2 = sk1 / sk2;
                Console.Write("Rezutats: " + darbiba2);
            }
            else if (zime == "+")
            {
                int darbiba3 = sk1 + sk2;
                Console.Write("Rezutats: " + darbiba3);
            }
            else if (zime == "-")
            {
                int darbiba4 = sk1 - sk2;
                Console.Write("Rezutats: " + darbiba4);
            }
            else
            {
                Console.Write("Nederiga operacija");
            }
            //otrs variants
            switch(zime)
            {
                case "+":
                    Console.Write(sk1 + sk2);
                    break;
                case "-":
                    Console.Write(sk1 - sk2);
                    break;
                case "*":
                    Console.Write(sk1 * sk2);
                    break;
                case "/":
                    Console.Write(sk1 / sk2);
                    break;
                default:
                    Console.Write("Nederiga operacija");
                    break;
            }
            
        }
        static void uzdevums2()
        {
            Console.Write("Ievadi temperaturu: ");
            float sk1 = float.Parse(Console.ReadLine());
            Console.Write("Ievadi gradu mervienibu: ");
            string mer = Console.ReadLine().ToLower();
            Console.Write("Ievadi jauno mervienibu: ");
            string jmer = Console.ReadLine().ToLower();
            
            float farenheits = sk1 * 9 / 5 + 32;
            float kelvins = sk1 + 273.15f;
            float KuzC = sk1 - 273.15f;
            float FuzC = (sk1 - 32) * 9 / 5;
            float FuzK = (sk1 - 32) * 9 / 5 + 273.15f;
            float KuzF = (sk1 - 273.15f) * 9 / 5 + 32;

            if (mer == "c" && jmer == "f")
            {
                Console.Write("Gradi pec Farenheita: " + farenheits);
            }
            else if (mer == "c" && jmer == "k")
            {
                Console.Write("Gradi pec Kelvina: " + kelvins);
            }
            else if (mer == "f" && jmer == "c")
            {
                Console.Write("Gradi pec Celsija: " + FuzC);
            }
            else if (mer == "f" && jmer == "k")
            {
                Console.Write("Gradi pec Kelvina: " + FuzK);
            }
            else if (mer == "k" && jmer == "f")
            {
                Console.Write("Gradi pec Farenheita: " + KuzF);
            }
            else if (mer == "k" && jmer == "c")
            {
                Console.Write("Gradi pec Celsija: " + KuzC);
            }
            else
            {
                Console.Write("Nederiga mervieniba");
            }

            //otrs variants
            switch(mer)
            {
                case "c":
                    switch(jmer)
                    {
                        case "k":
                            Console.Write("Gradi pec Kelvina: " + kelvins);
                            break;
                        case "f":
                            Console.Write("Gradi pec Farenheita: " + farenheits);
                            break;
                    }
                    break;
                case "k":
                    switch (jmer)
                    {
                        case "c":
                            Console.Write("Gradi pec Celsija: " + KuzC);
                            break;
                        case "f":
                            Console.Write("Gradi pec Farenheita: " + KuzF);
                            break;
                    }
                    break;
                case "f":
                    switch (jmer)
                    {
                        case "c":
                            Console.Write("Gradi pec Celsija: " + FuzC);
                            break;
                        case "k":
                            Console.Write("Gradi pec Kelvina: " + FuzK);
                            break;
                    }
                    break;
            }
        }
    }
}
