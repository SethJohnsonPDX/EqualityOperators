using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            bool greaterAnd = (2 > 2) && (5 > 4);

            Console.WriteLine(greaterAnd);
            Console.ReadLine();
            // Should give False

            bool greaterOr = (3 > 2) || (4 > 4);

            Console.WriteLine(greaterOr);
            Console.ReadLine();
            // Should give True

            bool notEqual = (2 + 2) != 4;

            Console.WriteLine(notEqual);
            Console.ReadLine();
            // Should give False

        }
    }
}
