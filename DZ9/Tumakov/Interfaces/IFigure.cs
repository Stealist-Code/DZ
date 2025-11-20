using System;
using System.Drawing;
using Tumakov.Enums;

namespace Tumakov.Interfaces
{
    public interface IFigure
    {
        void MoveVertical(float distanceY);
        void MoveHorizontal(float distanceX);
        void ChangeColor(Color newColor);
        bool GetStatus(Status statusFigure);
    }
}
