using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGeometry
{
    class Triangle : Figure
    {
        private double SideA;
        private double SideB;
        private double SideC;
        public Triangle(string color, double sideA, double sideB, double sideC)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
            this.Color = color;
        }

        public override void Area()
        {
            double sideA = this.SideA;
            double sideB = this.SideB;
            double sideC = this.SideC;
            string color = this.Color;
            double s = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
            Console.WriteLine("The area of the " + color + " Triangle is: " + area);
        }
    }
}
