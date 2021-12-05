using System;
using System.IO;
using System.Linq;

namespace CodeOfAdvent2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:..\..\..\input.txt";
            TextReader text = File.OpenText(path);
            var allLines = text.ReadToEnd().Split("\n");
            var instructionList = allLines.Select(x => x.Split(" ")).ToList();
            var horizontalValue = 0;
            var verticalValue = 0;
            var total = 0;

            foreach(var instruction in instructionList)
            {
                if (instruction[0] == "forward")
                {
                    horizontalValue += int.Parse(instruction[1]);
                }
                else if(instruction[0] == "down")
                {
                    verticalValue += int.Parse(instruction[1]);
                }
                else if(instruction[0] == "up")
                {
                    verticalValue -= int.Parse(instruction[1]);
                }
            }

            total = horizontalValue * verticalValue;
            Console.Write(total);
        }
    }
}
