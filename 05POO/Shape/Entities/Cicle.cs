using System;
using Shapes.Entities.Enums;

namespace Shapes.Entities
{
    class Cicle : Shape
    {
        public double Radius { get; set; }

        public Cicle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
