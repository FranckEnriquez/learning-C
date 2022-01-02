using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherNameSpace
{
    class MyClass
    {
        // Puede ser visto en cualquier clase
        public void MetodoPublico()
        {
            Console.WriteLine("Llamando a método público");
        }

        // Puede ser visto desde esta clase o cualquier
        // clase que herede MiClase
        protected void MetodoProtected()
        {
            Console.WriteLine("Llamando a método protected");

        }

        // Puede ser visto por cualquier clase dentro del mismo assembly (ensambleado)
        // assembly -> un programa C#, empaquetadim se almacena en un conjunto de clases y namespaces
        // un DDL en microsoft son assemblies

        internal void MetodoInternal()
        {
            Console.WriteLine("Llamando a método internal");
        }

        // Puede ser visto sólo por está clase
        private void MetodoPrivado()
        {
            Console.WriteLine("Llamando a método privado");
        }
    }
}
