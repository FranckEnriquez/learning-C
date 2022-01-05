using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseObject
{
    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public override bool Equals(object obj)
        {
            // Son necesarias estos dos if statements
            // cuando se usa el método Equals
            if (obj == null)
            {
                return false;
            }

            Persona p = obj as Persona;
            if (p == null)
            {
                return false;
            }

            return (this.Nombre == p.Nombre) && (this.Edad == p.Edad);

        }

        public override int GetHashCode()
        {
            int hash = 17; // iniciar ´con número primo
            hash = (hash * 7) + Nombre.GetHashCode();
            hash = (hash * 7) + Edad.GetHashCode();

            return hash;
        }
    }
}
