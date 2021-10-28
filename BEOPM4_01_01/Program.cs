using System;

namespace BEOPM4_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;

            string strInterpolated = $"Double backslash: \\\\. Integer a: {a}. Quotation char:\"quote\"";
            string strVerbatim = @"Double backslash: \\. Quotation char:""quote""";
            string strVerbatimInterpolated = @$"Double backslash: \\. Integer a: {a}. Quotation char:""quote""";

            Console.WriteLine(strInterpolated);
            Console.WriteLine(strVerbatim);
            Console.WriteLine(strVerbatimInterpolated);

            char[] charArray1 = { 'a', 'b', 'c' };
            string str1 = new string(charArray1);
            Console.WriteLine(str1);

            string str2 = new string('*', 50);
            Console.WriteLine(str2);

            char[] charArray2 = str2.ToCharArray();
            Console.WriteLine(charArray2.Length);
        }
    }
}
