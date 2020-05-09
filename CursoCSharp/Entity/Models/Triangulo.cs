using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Models
{
    public class Triangulo : Figura
    {

        public Triangulo(double b, double h) : base(b, h)
        {

        }

        public override double Area()
        {
            return ( 0.5 * x * y);
        }

        public override double AreaAbstracto()
        {
            return ( 0.5 * x * y);
        }
    }
}
