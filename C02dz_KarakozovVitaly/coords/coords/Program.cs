using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace coords
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            while ((input = Console.ReadLine()) != null) // читать пока есть строки
            {
                // Раз не вышли, значит строка прочлась таки
                var coords = new Coords(input);
                Console.WriteLine(coords.FineForm());
            }
        }
    }
}
