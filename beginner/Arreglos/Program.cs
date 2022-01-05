﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sintaxis 1
            int[] arreglo = new int[5];
            arreglo[0] = 1;
            arreglo[1] = 0;
            arreglo[2] = 20;
            arreglo[3] = -4;
            arreglo[4] = 8;

            Console.WriteLine(arreglo[0]);

            // Sintaxis 2
            // Los arreglos no pueden cambiar de tamaño una vez inicializados
            char[] vocales = new char[] { 'a', 'e', 'i', 'o', 'u' };
            Console.WriteLine(vocales[2]);

            // Sintaxis 3
            double[] numeros = { 1.1, 2.2, 3.4, 5.8 };
            Console.WriteLine(numeros[2]);
            Console.WriteLine("Tamaño: {0}", numeros.Length);

            // mostrar último elemento
            Console.WriteLine(numeros[numeros.Length - 1]);
        }
    }
}
