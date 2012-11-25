using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace primzahlen
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, max;
            List<Prime> primes = new List<Prime>(); 

            try
            {
                min = Convert.ToInt32(args[0]);
                max = Convert.ToInt32(args[1]);
            }

            catch(Exception e) {
                Console.Write("Bitte geben Sie die kleinste Zahl an: ");
                min = Convert.ToInt32(Console.ReadLine()); 

                Console.Write("Bitte geben Sie die größte Zahl an: ");
                max = Convert.ToInt32(Console.ReadLine()); 
            }

            for (int i = min; i <= max; i++)
            {
                primes.Add(new Prime(i, isPrime(i)));  
            }

            Console.WriteLine("Im Radius von {0} - {1} befinden sich {2} Zahlen \n\n", min, max, primes.Count);

            Console.WriteLine("Was möchten Sie machen?\n\n");
            Console.WriteLine("1: Alle Zahlen ausgeben");
            Console.WriteLine("2: Nur Primzahlen ausgeben");
            Console.WriteLine("3: Nur nicht Primzahlen ausgeben");
            Console.WriteLine("4: Beenden");

            Console.Write("\n\n Eingabe: "); 

            switch (Console.ReadLine())
            {

                case "1" :
                    foreach (var prime in primes)
                    {
                        Console.WriteLine("Die Zahl {0} ist {1}", prime.Number, prime.IsPrime ? "eine Primzahl" : "keine Primzahl");
                    }
                    Console.ReadLine(); 
                    break;

                case "2":
                    foreach (var prime in primes.Where(p => p.IsPrime == true))
                    {
                        Console.WriteLine("Die Zahl {0} ist {1}", prime.Number, prime.IsPrime ? "eine Primzahl" : "keine Primzahl");
                    }
                    Console.ReadLine(); 
                    break;

                case "3":
                    foreach (var prime in primes.Where(p => p.IsPrime == false))
                    {
                        Console.WriteLine("Die Zahl {0} ist {1}", prime.Number, prime.IsPrime ? "eine Primzahl" : "keine Primzahl");
                    }
                    Console.ReadLine(); 
                    break;

                case "4":
                    Console.WriteLine("Ende: Bitte die Entertaste drücken!");
                    Console.ReadLine(); 
                    break;

                default: break; 
            }
        }

        private static bool isPrime(int number)
        {

            // Wenn die Zahl / 2 keinen Rest ergibt
            // Also durch 2 Teilbar ist
            // handelt es sich nicht um eine Primzahl
            if (number % 2 == 0)
            {
                return false;
            }

            // Wir bilden eine Zahlschleife beginnend ab der 3 sowie allen ungeraden
            // Zahlen, wir fragen bis zum Faktor dieser Zahl und gehen 2 Schritte weiter
            for (int i = 3; i * i <= number; i += 2)
            {

                // Wenn die eingegebene Zahl durch die Zählschleife ohne Rest
                // teilbar ist
                // kann es sich auch nicht um eine Primzahl handeln
                if (number % i == 0)
                {
                    return false;
                }
            }

            // Jede andere Zahl, für die die Bedingungen oben nicht zutreffen
            // ist eine Primzahl
            return true;
        }
    }
}
