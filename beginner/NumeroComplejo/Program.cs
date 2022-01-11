using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroComplejo
{
    class Program
    {
        static void Main(string[] args)
        {
            Complejo c1 = new Complejo(3, 4);
            Complejo c2 = new Complejo(-0.5, 2);

            Console.WriteLine(c1);
            Console.WriteLine(c2);
        }
    }
}
