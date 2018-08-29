using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TALogIODrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number");
            string num = Console.ReadLine();

            File.WriteAllText(@"C:\Users\Keenan\Desktop\IOtest.txt", num);
            string text = File.ReadAllText(@"C:\Users\Keenan\Desktop\IOtest.txt");
            Console.WriteLine(text);

            Console.ReadLine();
        }
    }
}
