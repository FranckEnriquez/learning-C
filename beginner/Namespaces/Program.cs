using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    class Class1
    {
        public void Method()
        {
            Console.WriteLine("Inside of my NameSpace class");
        }
    }
}

namespace AnotherNameSpace
{
    class Class1
    {
        public void Method()
        {
            Console.WriteLine("Inside of my AnotherNameSpace class");
        }
    }
}

namespace Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creando objetos de clases contenidas en otros namespaces
            // Particular manera de sintaxis para crear objetos de clases de otros namespaces
            // Se le conoce como "Nombre totalmente Cualificado" o "Fully qualified name"
            MyNamespace.Class1 obj1 = new MyNamespace.Class1();
            AnotherNameSpace.Class1 obj2 = new AnotherNameSpace.Class1();

            obj1.Method();
            obj2.Method();
        }
    }
}
