using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datatype
{
    class Program
    {
        static void Main(string[] args)
        {
            float flmin =float.MinValue;
            float flmax = float.MaxValue;
            Console.WriteLine("minvalue={0 },maxvalue={1}", flmin, flmax);
           // Console.ReadKey();
            float flvar= 1f/3;
            Double dlvar = 1d /3;
            decimal dcvar = 1m /3;
            Console.WriteLine("float value={0}/n double value ={1}/n decimal value ={2}",flvar,dlvar,dcvar);
            Console.ReadKey();
        }
    }
}
