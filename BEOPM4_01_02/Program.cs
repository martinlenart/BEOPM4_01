using System;

namespace BEOPM4_01_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string strNull = null;
            string strEmpty = "";
            string strWhiteSpace = " ";

            Console.WriteLine(string.IsNullOrEmpty(strNull));       //True
            Console.WriteLine(string.IsNullOrEmpty(strEmpty));      //True
            Console.WriteLine(string.IsNullOrEmpty(strWhiteSpace)); //False

            Console.WriteLine(string.IsNullOrWhiteSpace(strNull));          //True
            Console.WriteLine(string.IsNullOrWhiteSpace(strEmpty));         //True
            Console.WriteLine(string.IsNullOrWhiteSpace(strWhiteSpace));    //True
        }
    }
}
