using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_App
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(" hello world");
            //  Console.ReadKey();
            // int x = 45;
            // Console.WriteLine("{0}",x);
            // Console.ReadKey();
            int charmin = char.MinValue;
            int charmax = char.MaxValue;
            char myvar = 'g';
            int myvarvalue = 'g'; 
            Console.WriteLine("min value = {0} max value ={1} char value ={2} myvarvalue ={3}",charmin ,charmax,myvar,myvarvalue);
            string mystring = "this is my varaible";
            Console.WriteLine("my string is {0}",mystring);
            char myvar2 = 'A';
            int myvar2value = 'A';
            char myvar3 = 'a';
            char myvar3value = 'a';
            string mystring2="this is my charater A value";
            string mystring3 = "this is my character a value";
            Console.WriteLine("this is my character {0} value {1} this is my character {2} value {3}", myvar2, myvar2value, myvar3, myvar3value);
            Console.ReadKey();
        }
    }
}
