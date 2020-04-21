using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGeometry
{
    class Square : Figure
    {
        private float EdgeSize;
        public Square(string color, float edgeSize)
        {
            this.Color = color;
            this.EdgeSize = edgeSize;
        }
        public override void Area()
        {
            float edgeSize = this.EdgeSize;
            string color = this.Color;
            float area = edgeSize * edgeSize;
            Console.WriteLine("The area of the " + color + " Square is: " + area);
        }
    }
}
