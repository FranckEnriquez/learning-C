using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroComplejo
{
    struct Complejo
    {
        public double Real { get; }
        public double Imaginario { get; }

        public Complejo(double real, double imaginario) : this()
        {
            Real = real;
            Imaginario = imaginario;
        }

        public Complejo Suma(Complejo other)
        {
            return new Complejo(Real + other.Real, Imaginario + other.Imaginario);
        }

        public Complejo Multiplicar(Complejo other)
        {
            return new Complejo(Real * other.Real - Imaginario * other.Imaginario,
                Real * other.Imaginario + Imaginario * other.Real);
        }

        public override string ToString()
        {
            return string.Format("Re: {0:0.0}, Im: {1:0.0}i", Real, Imaginario);
        }
        // TO DO: Producto escalar, módulo, ...

    }
}
