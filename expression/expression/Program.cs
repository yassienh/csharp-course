using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expression
{
    class Program
    {
        static void Main(string[] args)
        {
            // float myvar = 10.5f;
            // float myvar2 = 56.9f;
            // float temp = myvar + myvar2;
            int myvar1 = 10;
            int myvar2 = 15;
            int temp1 = myvar1 + myvar2;
            int temp2 = myvar1 / myvar2;
            int temp3 = myvar2 - myvar1;
            int temp4 = myvar1 * myvar2;
            int temp5 = myvar1 % myvar2;
            string mystr = "my name is eman";
            string mystr2 = "my son name is yassen";
            string mystr3 = mystr + mystr2;
            Console.WriteLine("the result is {0} the result is {1} the result is{2} the result is {3} the result is {4}\n\n {5}",temp1,temp2,temp3,temp4,temp4,mystr3);
            Console.ReadKey();
        }
    }
}
