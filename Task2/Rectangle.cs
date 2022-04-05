using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Rectangle : Point
    {
        #region Конструкторы
        public Rectangle() : this(0, 0, 1, 1, Color.red, true) { }
        public Rectangle(Int32 x, Int32 y) : this(x, y, 1, 1, Color.red, true) { }
        public Rectangle(Int32 x, Int32 y, UInt32 height, UInt32 width) : this(x, y, height, width, Color.red, true) { }
        public Rectangle(Int32 x, Int32 y, UInt32 height, UInt32 width, Color color) : this(x, y, height, width, color, true) { }
        public Rectangle(Int32 x, Int32 y, UInt32 height, UInt32 width, Color color, bool visible)
            : base(x, y, color, visible)
        {
            _height = height;
            _width = width;
        }
        #endregion

        private Int32 _height;
        private Int32 _width;

        public override Int32 CalcSquare()
        {
            return _height * _width;
        }
        public override String ToString()
        {
            return $"Координаты точки верхнего левого угла(X,Y): ({_x},{_y})\n" +
                   $"Высота: {_height}\n" +
                   $"Ширина: {_width}\n" +
                   $"Цвет: {_color}\n" +
                   $"Видимость: {IsVisible()}";
        }
    }
}
