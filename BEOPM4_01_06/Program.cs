using System;
using System.IO;
using System.Text;

namespace BEOPM4_01_06
{
    class Program
    {
        static void Main(string[] args)
        {
            var utf8Encoder = Encoding.UTF8;

            // Call Encoding.GetEncoding with a standard IANA name to obtain an encoding:
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Encoding chinese = Encoding.GetEncoding("GB18030");

            // The static GetEncodings method returns a list of all supported encodings:
            Console.WriteLine();
            foreach (EncodingInfo info in Encoding.GetEncodings())
                Console.WriteLine(info.Name);

            // Encoding into byte array
            string str1 = "The quick brown fox catches the white rabbit";
            byte[] utf8Bytes = System.Text.Encoding.UTF8.GetBytes(str1);
            byte[] utf16Bytes = System.Text.Encoding.Unicode.GetBytes(str1);
            byte[] utf32Bytes = System.Text.Encoding.UTF32.GetBytes(str1);

            Console.WriteLine();
            Console.WriteLine(str1.);
            Console.WriteLine(utf8Bytes.Length);    // 44
            Console.WriteLine(utf16Bytes.Length);   // 88
            Console.WriteLine(utf32Bytes.Length);   // 176

            string original1 = System.Text.Encoding.UTF8.GetString(utf8Bytes);
            string original2 = System.Text.Encoding.Unicode.GetString(utf16Bytes);
            string original3 = System.Text.Encoding.UTF32.GetString(utf32Bytes);

            Console.WriteLine();
            Console.WriteLine(original1);          
            Console.WriteLine(original2);          
            Console.WriteLine(original3);

            //Encoding into a file
            StringBuilder aBook2 = new StringBuilder();
            for (int i = 0; i < 10_000; i++)
            {
                aBook2.AppendLine($"{str1}\n");
            }

            Console.WriteLine();
            Console.WriteLine($"Files are written to: {fname("")}");
            File.WriteAllText(fname("EncodeUTF8.txt"), aBook2.ToString(), Encoding.UTF8);
            File.WriteAllText(fname("EncodeUnicode.txt"), aBook2.ToString(), Encoding.Unicode);
            File.WriteAllText(fname("EncodeUTF32.txt"), aBook2.ToString(), Encoding.UTF32);
        }

        static string fname(string name)
        {
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            documentPath = Path.Combine(documentPath, "BEOPM4", "Examples");
            if (!Directory.Exists(documentPath)) Directory.CreateDirectory(documentPath);
            return Path.Combine(documentPath, name);
        }
    }
}
//Exercise
//1.    Make a small program that reads a sentence from a user, converts the sentence to 3 byte arrays with UTF8, 
//      Unicode, UTF32 and print out the arrays and their length.      
