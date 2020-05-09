using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Models
{
    public class Cilindro : Figura
    {

        public Cilindro (double r, double h) : base(r, h)
        {

        }

        public override double Area()
        {
            var AreaLateral = (2 * PI * x * y);
            var AreaBase = (PI * (x * x));

            return (2 * AreaBase) + (AreaLateral);
        }

        public override double AreaAbstracto()
        {
            var AreaLateral = (2 * PI * x * y);
            var AreaBase = (PI * (x * x));

            return (2 * AreaBase) + (AreaLateral);
        }
    }
}
