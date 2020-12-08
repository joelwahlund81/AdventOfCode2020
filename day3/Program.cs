using System;

namespace day3
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = System.IO.File.ReadAllLines(@"C:\Users\admin\source\repos\AdventOfCode2020\day3\input.txt");

            var treesEncountered = Hill.GoDown(lines);

            Console.WriteLine("Hello World!");

            Console.WriteLine($"Under din väg nedåt kommer du stöta på {treesEncountered} träd");

            Console.ReadLine();
        }
    }
}
