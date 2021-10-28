using System;
using System.Text;

namespace BEOPM4_01_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"\nBig-O speed test:");
            const int HugeNrCreated = 10_000;
            string strSentence = "The quick brown fox catches the white rabbit\n";

            // string concat takes about 586ms on my machine
            var starttime = DateTime.Now;
            string aBook1 = "";
            for (int i = 0; i < HugeNrCreated; i++)
            {
                aBook1 += strSentence;
            }
            var elapsedTime = DateTime.Now - starttime;
            Console.WriteLine($"Created a book with {HugeNrCreated:N0} " +
                $"sentences using string contatination in {elapsedTime.TotalMilliseconds:N0} ms.");

            
            // StringBuilder takes about 0ms on my machine
            starttime = DateTime.Now;
            StringBuilder aBook2 = new StringBuilder();
            for (int i = 0; i < HugeNrCreated; i++)
            {
                aBook2.AppendLine(strSentence);
            }
            elapsedTime = DateTime.Now - starttime;
            Console.WriteLine($"Created a book with {HugeNrCreated:N0} " +
                $"sentences using StringBuilder in {elapsedTime.TotalMilliseconds:N0} ms.");
        }
    }
}
