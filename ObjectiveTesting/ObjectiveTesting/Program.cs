using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectiveTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            String s0;
            String s1;
            String s2;
            bool b0;
            bool b1;
            bool b2;

            s0 = "Hit";
            s1 = "Hit";
            s2 = "Hit";

            b0 = s0 == s1;
            b1 = s1 == s2;
            b2 = s0 == s2;

            Console.WriteLine("s0 == s1 = " + b0);
            Console.WriteLine("s1 == s2 = " + b1);
            Console.WriteLine("s0 == s2 = " + b2);
            Console.WriteLine();

            s0 = s2;
            s1 = s2;

            b0 = s0 == s1;
            b1 = s1 == s2;
            b2 = s0 == s2;

            Console.WriteLine("s0 == s1 = " + b0);
            Console.WriteLine("s1 == s2 = " + b1);
            Console.WriteLine("s0 == s2 = " + b2);

            Console.ReadKey();
        }
    }
}
