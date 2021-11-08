using System;
using System.Globalization;

namespace BEOPM4_01_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "The quick brown fox catches the white rabbit";

            Console.WriteLine();
            Console.WriteLine(str1.StartsWith("The"));  //True
            Console.WriteLine(str1.EndsWith("rabbit")); //True
            Console.WriteLine(str1.IndexOf("white"));   //32
            Console.WriteLine(str1.Contains("fox"));    //True

            Console.WriteLine();
            Console.WriteLine(str1.Substring(32));          //white rabbit
            var s2 = str1.Insert(32, "sleepy ");
            Console.WriteLine(str1);   //...the white rabbit
            Console.WriteLine(s2);   //...the sleepy white rabbit
            Console.WriteLine(str1.Remove(32, 6));   //...the rabbit

            Console.WriteLine();
            Console.WriteLine(str1.PadLeft(50, '*'));   //******The quick..
            Console.WriteLine(str1.PadRight(50, '*'));   //..white rabbit******

            Console.WriteLine();
            string str2 = "   text with whitespaces     ";
            Console.WriteLine(str2.TrimStart());
            Console.WriteLine(str2.TrimEnd());
            Console.WriteLine(str2.Trim());             //text with whitespaces

            Console.WriteLine();
            Console.WriteLine(str1.Replace("rabbit", "bird"));  //...catches the white bird

            Console.WriteLine();
            string str3 = "indigo".ToUpper();
            string str4 = "indigo".ToUpper(CultureInfo.GetCultureInfo("tr-TR"));
            string str5 = "indigo".ToUpperInvariant();
            Console.WriteLine($"{str3} str3[0]:{(int) str3[0]}");
            Console.WriteLine($"{str4} str4[0]:{(int) str4[0]}");
            Console.WriteLine($"{str5} str5[0]:{(int) str5[0]}");

            Console.WriteLine();
            string[] strArray1 = str1.Split(' ');
            Console.WriteLine($"strArray1[0]: {strArray1[0]}  strArray1.Lenght: { strArray1.Length}");

            string str6 = string.Join('-', strArray1);
            Console.WriteLine(str6);

            Console.WriteLine();
            Console.WriteLine(str1 + str6);
            Console.WriteLine(string.Concat(str1, str6));
            Console.WriteLine(string.Concat(strArray1));
        }
    }
}
//Exercise
//1.    Make a small program that reads a sentence from a user, counts the number of vowels in the sentence, i.e.
//      a, e, i, o, u, y and informs the user how many vowels in the sentence.
//2.    Make a small Login program that asks a user for a user name and a password. The password
//      should be compared HashCode wise to stored password hash code. If Login 
//      successful write a welcome message
//3.    Extend the program to allow the user 3 login attempts
//4.    Refracture the Login code into a Method - bool TryLogin(string User, string password)
