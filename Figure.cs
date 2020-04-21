using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGeometry
{
    abstract class Figure
    {
        public string Color { get; set; }

        public abstract void Area();
    }
}
