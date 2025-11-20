using System;
using System.Drawing;
using Tumakov.Enums;

namespace Tumakov.Classes
{
    class Point: Figure
    {
        public Point(Color colorFigure, Status statusFigure, float[] сoordinatesCentreXY) : base(colorFigure, statusFigure, сoordinatesCentreXY) { }
        
        public virtual float Square()
        {
            return 1;
        }

    }
}
