using System;

namespace UgeSeddel2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Inddata

            Console.Write("Navn     :");
            string navn = Console.ReadLine();

            Console.Write("Timeløn  :");
            double timeløn = Convert.ToDouble(Console.ReadLine());

            Console.Write("Timer    :");
            double antalTimer = Convert.ToDouble(Console.ReadLine());

            // Beregn

            double løn = 0;
            double overTimer = 0;
            double normalLøn = 0;
            double overTidsLøn = 0;

            if (antalTimer <= 37.5)
            {
                løn = antalTimer * timeløn;
            }
            else
            {
                overTimer = antalTimer - 37.5;
                normalLøn = 37.5 * timeløn;
                overTidsLøn = overTimer * timeløn * 1.5;
                løn = normalLøn + overTidsLøn;
            }

            // Udskriv
            // Console.WriteLine(løn);

            // udskriv header
            Console.WriteLine("LØNSEDDEL {0, 69}", "FOR " + navn);
            Console.WriteLine("===============================================================================");
            Console.WriteLine();
            Console.WriteLine();

            if (overTimer == 0)
            {
                // normal timer
                Console.WriteLine("{0, 6:0.00} timer á {1, 6:0.00}{2, 58:0.00}", antalTimer, timeløn, løn);
                Console.WriteLine("                              --------");
            }
            else
            {
                // over timer
                Console.WriteLine("{0} timer i alt", antalTimer);
                Console.WriteLine("    heraf");
                Console.WriteLine("      {0, 6:0.00} timer á {1, 6:0.00}{2, 52:0.00}", 37.5, timeløn, normalLøn);
                Console.WriteLine("      {0, 6:0.00} timer á {1, 6:0.00}{2, 52:0.00}", overTimer, timeløn * 1.5, overTidsLøn);
                Console.WriteLine("                              --------");
            }
            // ialt 
            Console.WriteLine("                              I Alt: Kr. {0}", løn);
            Console.WriteLine("                              ==================");

            // bund
            Console.WriteLine("------------------------------------------------------");
        }
    }
}
