/// <summary>
/// https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#indices-and-ranges
/// </summary>

using System;

namespace IndicesAndRanges
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new string[]
            {
                            // index from start    index from end
                "The",      // 0                   ^9
                "quick",    // 1                   ^8
                "brown",    // 2                   ^7
                "fox",      // 3                   ^6
                "jumped",   // 4                   ^5
                "over",     // 5                   ^4
                "the",      // 6                   ^3
                "lazy",     // 7                   ^2
                "dog"       // 8                   ^1
            };              // 9 (or words.Length) ^0

            Console.WriteLine(words[^1] == words[words.Length - 1]); // True

            Console.WriteLine(string.Join(" ", words[1..4])); // quick brown fox

            Console.WriteLine(string.Join(" ", words[^2..^0])); // lazy dog

            Console.WriteLine(string.Join(" ", words[..])); // The quick brown fox jumped over the lazy dog

            Console.WriteLine(string.Join(" ", words[..4])); // The quick brown fox

            Console.WriteLine(string.Join(" ", words[6..])); // the lazy dog

            Range phrase = 1..4;

            Console.WriteLine(string.Join(" ", words[phrase])); // quick brown fox

            Console.ReadLine();
        }
    }
}
