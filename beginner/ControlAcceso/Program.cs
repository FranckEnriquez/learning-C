using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnotherNameSpace;

namespace ControlAcceso
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.MetodoPublico();
            obj.MetodoInternal();
            // el método protected y private no se pueden llamar
            // obj.MetodoProtected();
            // obj.MetodoPrivado();
        }
    }
}
