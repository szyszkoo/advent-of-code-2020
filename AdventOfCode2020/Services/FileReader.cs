using System;
using System.IO;

namespace AdventOfCode2020.Services
{
    public class FileReader
    {
        public string ReadFile(string filePath)
        {
            using (var sr = new StreamReader(filePath))
            {
                try
                {
                    return sr.ReadToEnd();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Could not open the file {filePath}");
                    Console.WriteLine(ex.Message);
                    return string.Empty;
                }
            }
        }
    }
}