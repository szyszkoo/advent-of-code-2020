using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode2020.Days;
using AdventOfCode2020.Services;

namespace AdventOfCode2020
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileReader = new FileReader();
            var parser = new Parser();
            var fullPath = Path.GetFullPath("Resources\\day1.txt");
            var dayService = new Day1();

            var lines = fileReader.ReadFile(fullPath);
            var values = parser.Parse<int>(lines);

            dayService.Execute(values);

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
