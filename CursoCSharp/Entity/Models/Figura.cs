using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Models
{
    public abstract class Figura
    {
        public const double PI = Math.PI;
        protected double x, y;

        public Figura()
        {

        }

        public Figura(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual double Area()
        {
            return x * y;
        }

        public abstract double AreaAbstracto();
       
    }
}
