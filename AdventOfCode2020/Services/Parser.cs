using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2020.Services
{
    public class Parser
    {
        public IEnumerable<T> Parse<T>(string textToParse)
        {
            var entries = textToParse.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            var results = entries.Select(entry => (T) Convert.ChangeType(entry, typeof(T)));

            return results;
        }
    }
}