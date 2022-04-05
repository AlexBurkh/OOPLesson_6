using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Circle : Point
    {
        #region Конструкторы
        public Circle(Int32 x, Int32 y, UInt32 radius, Color color, Boolean visible)
            : base(x, y, color, visible)
        {
            _radius = radius;
        }
        public Circle(int x, int y, UInt32 radius, Color color) : this(x, y, radius, color, true) { }
        public Circle(int x, int y, UInt32 radius) : this(x, y, radius, Color.red, true) { }
        public Circle(int x, int y) : this(x, y, 1, Color.red, true) { }
        public Circle() : this(0, 0, 1, Color.red, true) { }
        #endregion

        private UInt32 _radius;

        public override Int32 CalcSquare()
        {
            return Math.PI * _radius * _radius;
        }
        public override string ToString()
        {
            return $"Координаты центра круга (X,Y): ({_x},{_y})\n" +
                   $"Радиус круга: {_radius}" +
                   $"Цвет: {_color}\n" +
                   $"Видимость: {IsVisible()}";
        }
    }
}
