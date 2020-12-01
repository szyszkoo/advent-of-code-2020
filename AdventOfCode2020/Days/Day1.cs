using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020.Days
{
    public class Day1
    {
        private const int DesiredValue = 2020;

        public int Execute(IEnumerable<int> inputEntries)
        {
            return FindThreeComponents(inputEntries);
        }

        private int FindTwoComponents(IEnumerable<int> inputEntries)
        {
            foreach (var inputEntry in inputEntries)
            {
                foreach (var secondEntry in inputEntries)
                {
                    if (inputEntry + secondEntry == DesiredValue)
                    {
                        var result = inputEntry * secondEntry;
                        Console.WriteLine(
                            $"Success! Values that sum to {DesiredValue} are: {inputEntry} and {secondEntry}.");
                        Console.WriteLine($"Result is: {result}");

                        return result;
                    }
                }
            }

            Console.WriteLine("Desired numbers not found.");
            return 0;
        }

        private int FindThreeComponents(IEnumerable<int> inputEntries)
        {
            var counter = 0;
            var ordered = inputEntries.OrderBy(x => x);
            foreach (var inputEntry in ordered)
            {
                foreach (var secondEntry in ordered)
                {
                    foreach (var thirdEntry in ordered)
                    {
                        Console.WriteLine($"Iteration: {counter}");
                        counter++;
                        if (inputEntry + secondEntry + thirdEntry == DesiredValue)
                        {
                            var result = inputEntry * secondEntry * thirdEntry;
                            Console.WriteLine(
                                $"Success! Values that sum to {DesiredValue} are: {inputEntry} and {secondEntry}.");
                            Console.WriteLine($"Result is: {result}");

                            return result;
                        }
                    }
                }
            }

            Console.WriteLine("Desired numbers not found.");
            return 0;
        }
    }
}