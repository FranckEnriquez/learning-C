using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Rectangulo
    {
        // propiedades públicas
        // Deben iniciar con letras mayúsculas
        // Atributos
        public int  Base { get; set; }
        public int Altura { get; set; }

        // Métodos
        public int CalcularArea()
        {
            return Base * Altura;
        }

        // Esta clase tiene 2 atributos/propiedades y 1 método
    }
}
