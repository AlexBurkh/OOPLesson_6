using System;

namespace Task2
{
    public class Point : Figure
    {
        #region Конструкторы
        public Point(Int32 x, Int32 y, Color color, Boolean visible)
        {
            _x = x;
            _y = y;
            _color = color;
            _visible = visible;
        }
        public Point(Int32 x, Int32 y, Color color) : this(x, y, color, true) { }
        public Point(Int32 x, Int32 y) : this(x, y, Color.red, false) { }
        public Point() : this(0,0, Color.red, false) { }
        #endregion

        protected Int32 _x = 0;
        protected Int32 _y = 0;

        public override void MoveX(Int32 shift)
        {
            _x += shift;
        }
        public override void MoveY(Int32 shift)
        {
            _y += shift;
        }
        public override string ToString()
        {
            return $"Координаты (X,Y): ({_x},{_y})\n" +
                   $"Цвет: {_color}\n" +
                   $"Видимость: {IsVisible()}";
        }
        public virtual Int32 CalcSquare()
        {
            return 0;
        }
    }
}
