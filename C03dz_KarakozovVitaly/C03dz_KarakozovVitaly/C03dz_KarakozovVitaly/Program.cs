using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03dz_KarakozovVitaly
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "A";

            while (true) 
            {
                str += str;
                Console.WriteLine(str.Length);
            }


        }
    }
}
