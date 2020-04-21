using System;

namespace SimpleGeometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Square sq1 = new Square("Yellow", 5);
            sq1.Area();

            Circle c1 = new Circle("Red", 2);
            c1.Area();

            Triangle t1 = new Triangle("Blueish", 5, 5, 5);
            t1.Area();
        }
    }
}
