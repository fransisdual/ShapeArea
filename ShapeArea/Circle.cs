using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeArea
{

    public class Circle : IShape
    {
        public int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public Circle()
        {
            this.radius = 0;
        }

        // Pi*r^2
        public double Area 
        {
            get { return Math.PI * Math.Pow(radius, 2); }
        }
    }
}
