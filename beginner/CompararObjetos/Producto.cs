using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompararObjetos
{
    class Producto : IComparable<Producto>
    {
        public string Codigo { get; set; }
        public decimal Precio { get; set; }

        // método de la interfaz 
        // la interfaz permite comparar objetos no predefinidos como arrays
        public int CompareTo(Producto other)
        {
            // > 0 mayor
            // == 0 iguales
            // < 0 menor
            if (this.Precio > other.Precio) return 1;
            if (this.Precio == other.Precio) return 0;

            return -1;
        }

        //  TODO: crear constructores, método ToString
    }
}
