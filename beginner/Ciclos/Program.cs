using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ciclo for
            Console.WriteLine("Usando ciclo for");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Valor del contador i: {0}", i);
            }

            // Ciclo while
            Console.WriteLine("\nUsando ciclo while");
            int n = 0; // declaración del contador
            while (n < 5)
            {
                Console.WriteLine("Valor del contador n: {0}", n);
                n++;
            }

            // Ciclor Do - while 
            Console.WriteLine("\nUsando ciclo Do while");
            int c = 10;
            do
            {
                Console.WriteLine("Valor del contador c: {0}", c);
                c++;
            } while (c < 5);            
        }
    }
}
