using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b, total;

            a = "Visual";
            b = "Studio";

            total = a + b;

            Console.WriteLine(total.Length.ToString());
            Console.ReadKey();
        }
    }
}
