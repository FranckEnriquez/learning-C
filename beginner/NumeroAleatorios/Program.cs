using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroAleatorios
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(10);
            int mes = rnd.Next(1, 13);
            int dado = rnd.Next(1, 7);
            double proba = rnd.NextDouble();
            Console.WriteLine(mes);
            Console.WriteLine(dado);
            Console.WriteLine(proba);

            // Llenar un arreglo con números aleatorios
            int[] arreglo = new int[5];
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = rnd.Next(0, 101);
            }

            foreach (var num in arreglo)
            {

                Console.WriteLine(num);
            }
        }
    }
}
