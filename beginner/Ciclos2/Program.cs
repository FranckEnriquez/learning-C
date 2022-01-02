using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Uso de break");
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break; // terminar el ciclo
                }
                Console.WriteLine("Valor del contador i: {0}", i);
            }

            Console.WriteLine("Uso de continue");
            int n = 0;
            while (n < 10)
            {
                if (n % 2 == 0)
                {
                    n++;
                    continue;
                }
                Console.WriteLine("Valor del contador n: {0}", n);
                n++;

            }

            Console.WriteLine("Uso de continue con ciclo for");
            for (int i = 1; i < 15; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine("Contador divisible entre 3 o 5 {0}", i);
                    continue;
                }
                Console.WriteLine("{0}", i);
            }
        }
    }
}
