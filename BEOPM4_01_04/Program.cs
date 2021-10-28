using System;
using System.Globalization;

namespace BEOPM4_01_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello" == "HELLO");
            Console.WriteLine(string.Equals("hello", "HELLO"));
            Console.WriteLine(string.Equals("hello", "HELLO", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine(string.CompareOrdinal("Älv", "Åke")); // -1
            Console.WriteLine(string.Compare("Älv", "Åke"));        // 1 in a Swedish Language

            Console.WriteLine(string.Compare("Müller", "Muller", false, CultureInfo.GetCultureInfo("de-DE"))); //1
        }
    }
}
