using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGeometry
{
    class Circle : Figure   
    {
        private double Radius;

        public Circle(string color, double radius)
        {
            this.Color = color;
            this.Radius = radius;
        }

        public override void Area()
        {
            double radius = this.Radius;
            string color = this.Color;
            double pi = Math.PI;
            double area = (pi * (radius * radius));
            Console.WriteLine("The area of the " + color + " Circle is: " + area);
        }
    }
}
