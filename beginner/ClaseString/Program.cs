using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseString
{
    class Program
    {
        static void Main(string[] args)
        {
            // Concatenacion de cadenas
            Console.WriteLine("Hola " + "mundo");
            Console.WriteLine(string.Concat("Hola ", "mundo"));

            string cadena = "Esta es una cadena de prueba";
            Console.WriteLine(cadena);
            Console.WriteLine("Tamaño {0}: " + cadena.Length);
            Console.WriteLine("Tamaño {0}: " + cadena.ToUpper());
            Console.WriteLine("Tamaño {0}: " + cadena.ToLower());

            // Método replace
            Console.WriteLine("Replace:  " + cadena.Replace(" ", ""));
            Console.WriteLine("Carácter en índice 0: " + cadena[0]);
            Console.WriteLine("Carácter en índice 1:: " + cadena[1]);

            // Método Substring
            Console.WriteLine("Substring (1-8): " + cadena.Substring(1, 8));

            // Método Contains
            Console.WriteLine("cadena contiene \"es\"? " + cadena.Contains("es"));

            // Metodo StartsWith
            Console.WriteLine("cadena empieza con \"La\"? " + cadena.StartsWith("La"));

            // Verificar si una cadena es nula o vacía
            string nula = null;
            Console.WriteLine("nula es null?" + string.IsNullOrEmpty(nula));
            Console.WriteLine("cadena es null?" + string.IsNullOrWhiteSpace(null));

            // Obtener la posición de un dato
            Console.WriteLine("Posición de la cade \"de\": " + cadena.IndexOf(cadena));
        } 
    }
}
