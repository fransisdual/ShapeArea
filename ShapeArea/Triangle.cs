using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeArea
{
   public class Triangle : IShape
    {

        int sideA, sideB, sideC;

        public Triangle(int sideA, int sideB, int sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public Triangle()
        {
            this.sideA = sideB = sideC = 0;
        }

        public double Area
        {
            get 
            {
                double p = (sideA + sideB + sideC) / 2;

                return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            }
        }

        //теорема пифагора
        public bool IsRight()
        {
            return (Math.Pow(sideA, 2) == Math.Pow(sideB, 2) + Math.Pow(sideC, 2)
                || Math.Pow(sideB, 2) == Math.Pow(sideA, 2) + Math.Pow(sideC, 2)
                || Math.Pow(sideC, 2) == Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
        }

    }
}
