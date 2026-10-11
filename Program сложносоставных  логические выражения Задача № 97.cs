using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program97
{
    internal class Program
    {
        static void Main()
        {

            bool result = !(10 >= 10) || (5 < 3) && (2 == 2) || !(false);
            Console.WriteLine(result); // True
        }
    }
}



