using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string name = Console.ReadLine();
            string reverse = "";
            for (int i=name.Length-1; i>=0; i--)
            {
                reverse = reverse + name[i];
            }
            Console.WriteLine(reverse);
            Console.Read();

        }
    }
}
