using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeArea
{
    public class Shape : IShape
    {
        IShape shape;
        public double Area 
        { 
            get { return shape.Area; }
        }
    }
}
