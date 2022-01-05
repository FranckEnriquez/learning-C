﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras
{
    struct Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        // Un tipo struct no puede definir un constructor vacío
        // pero si podemos crear otro tipo de constructores

        // Debe llamar al constructor vacío
        public Vector (double x, double y, double z) : this()
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double CalcularModulo()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        public Vector Suma(Vector other)
        {
            return new Vector(X + other.X, Y + other.Y, Z + other.Z);
        }

        public override string ToString()
        {
            return string.Format("[{0}, {1}, {2}]", X, Y, Z);
        }
    }
}
