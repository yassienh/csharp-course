using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace increement_and_decreement_expression
{
    class Program
    {
        static void Main(string[] args)
        {
            int myvar1 = 7;
            int myvar2 = 2;
            //int temp = myvar1-- / ++myvar2;
            // myvar1 = myvar2;
            myvar1 += myvar2; //myvar1=myvar1+myvar2
            myvar1 -=myvar2;
            myvar1 /= myvar2;
            myvar1 %= myvar2;

            // Console.WriteLine("{0}", temp);
            Console.WriteLine("{0}",myvar1);
            Console.ReadKey();
        }
    }
}
