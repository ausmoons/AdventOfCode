using System;
using System.IO;
using System.Linq;

namespace CodeOfAdvent
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:..\..\..\input1.txt";
            TextReader text = File.OpenText(path);
            var allLines = text.ReadToEnd().Split("\n");
            int[] allIntegers = allLines.Select(int.Parse).ToArray();
            int previousNumber = 0;
            int amountOfIncresedNUmber = 0;

            for(int i = 0; i < allIntegers.Length; i++)
            {
                if(previousNumber == 0)
                {
                    Console.WriteLine($"{allIntegers[i]} (N/A - no previous measurement)");
                }
                else if(allIntegers[i] > previousNumber)
                {
                    Console.WriteLine($"{allIntegers[i]} (increased)");
                    amountOfIncresedNUmber++;
                }
                else
                {
                    Console.WriteLine($"{allIntegers[i]} (decreased)");
                }
                previousNumber = allIntegers[i];
            }
            Console.WriteLine(amountOfIncresedNUmber);
        }
    }
}
