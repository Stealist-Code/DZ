using System;
using System.Drawing;
using Tumakov.Enums;

namespace Tumakov.Classes
{
    class Rectangle: Point
    {
        public float Length { get; set; }
        public float Width { get; set; }

        public Rectangle(Color colorFigure, Status statusFigure, float[] сoordinatesCentreXY, float lenght, float width) : base(colorFigure, statusFigure, сoordinatesCentreXY)
        {
            Width = width;
            Length = lenght;
        }

        public override float Square()
        {
            return Length * Width;
        }
    }
}
