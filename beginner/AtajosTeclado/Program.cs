using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtajosTeclado
{
    class Program
    {
        // ctrl F -> buscar
        // ctro H -> reemplazar
        static void Main(string[] args)
        {
            int miVariableSuper1000 = 1000000;
            Console.WriteLine(miVariableSuper1000);
            miVariableSuper1000++;
            int a = miVariableSuper1000 + 1;
            // .. mil operaciones
        }

        public static void MiMetodo()
        {
            //Ctrl + K + Ctrl C -> Comentar
            //Console.WriteLine("123");
            //Console.WriteLine("123");
            //Console.WriteLine("123");
            //Console.WriteLine("123");
            //Console.WriteLine("123");

            //Ctrl + K + Ctrl U -> Descomentar
            Console.WriteLine("123");
            Console.WriteLine("123");
            Console.WriteLine("123");
            Console.WriteLine("123");
            Console.WriteLine("123");
        }

        public static void Metodo2()
        {
            // cw + 2tabs -> atajo Console.WriteLine
            Console.WriteLine("Atajo super");
            Console.WriteLine("es lo mejor");
        }
        // Lista de los snippets
        // Ctrl K + Ctrl X
#if true
        string temp =  "esta es una prueba de los snippets";
#endif
        enum MyEnum
        {

        }
        
        // Ctrl + K + Ctrl + D -> formato de código si lo copias
        // prop + 2tabs -> propiedades de la clase
        class MiClase
        {
            public int MyProperty { get; set; }
        }
    }


}
