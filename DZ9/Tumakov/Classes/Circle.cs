using System;
using System.Drawing;
using Tumakov.Enums;

namespace Tumakov.Classes
{
    class Circle: Point
    {
        public float Radius { get; set; }

        public Circle(Color colorFigure, Status statusFigure, float[] сoordinatesCentreXY, float radius) : base(colorFigure, statusFigure, сoordinatesCentreXY)
        {
            Radius = radius;
        }
        public override float Square()
        {
            return (float)Math.Pow(Radius,2) * (float)Math.PI;
        }
    }
}
