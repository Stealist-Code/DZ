using System;
using System.Drawing;
using Tumakov.Interfaces;
using Tumakov.Enums;

namespace Tumakov.Classes
{
    abstract class Figure: IFigure
    {
        public Color ColorFigure { get; set; }
        public Status StatusFigure { get; set; }
        public float[] СoordinatesCentreXY { get; set; } = new float[2];

        public Figure(Color colorFigure, Status statusFigure, float[] сoordinatesCentreXY)
        {
            ColorFigure = colorFigure;
            StatusFigure = statusFigure;
            СoordinatesCentreXY = сoordinatesCentreXY;
        }

        public void MoveVertical(float distanceY)
        {
            if (distanceY != 0)
            {
                СoordinatesCentreXY[1] += distanceY;
            }
            else
            {
                Console.WriteLine("Нельзя передвинуть фигуру на 0");
            }
        }
        public void MoveHorizontal(float distanceX)
        {
            if (distanceX != 0)
            {
                СoordinatesCentreXY[0] += distanceX;
            }
            else
            {
                Console.WriteLine("Нельзя передвинуть фигуру на 0");
            }
        }
        public void ChangeColor(Color newColor)
        {
            if (newColor != null && StatusFigure != Status.Invisible)
            {
                ColorFigure = newColor;
            }
            else
            {
                Console.WriteLine("Нельзя покрасить фигуру в цвет Null или фигура невидимая");
            }
        }
        public bool GetStatus(Status statusFigure)
        {
            return StatusFigure == statusFigure;
        }
        public void GetInfo()
        {
            Console.WriteLine($"\nЦвет фигуры: {ColorFigure}\nСтатус фигуры: {StatusFigure}\nКоординаты центра фигуры: x - {СoordinatesCentreXY[0]}, y - {СoordinatesCentreXY[1]}");
        }
    }
}
