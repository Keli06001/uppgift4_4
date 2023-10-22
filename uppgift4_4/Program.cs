using System;

namespace Uppgift4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välj ett av följande alternativ.");
            Console.WriteLine("1. Subtrahera ett tal med ett annat");
            Console.WriteLine("2. Dividera ett tal med ett annat");
            Console.WriteLine("3. Avsluta programmet");
            int val = int.Parse(Console.ReadLine());
            if (val == 1)
            {
                Console.WriteLine();
                int s1 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                int s2 = int.Parse(Console.ReadLine());
                Console.WriteLine(s1 + "-" + s2 + "=");
                Console.WriteLine(s1 - s2); 
            }
            else if (val == 2)
            {
                Console.WriteLine();
                int d1 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                int d2 = int.Parse(Console.ReadLine());
                Console.WriteLine(d1 + "/" + d2 + "=");
                Console.WriteLine(d1 / d2);
            }
            else if (val == 3) 
            { 
            
            }
        }
    }
}