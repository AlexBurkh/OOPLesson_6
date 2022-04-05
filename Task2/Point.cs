using System;

namespace Task2
{
    public class Point : Figure
    {
        private int _x = 0;
        private int _y = 0;

        public override void MoveX(int shift)
        {
            _x += shift;
        }
        public override void MoveY(int shift)
        {
            _y += shift;
        }
        public override void Print()
        {
            Console.WriteLine($"Координаты (X,Y): ({_x},{_y})\n" +
                              $"Цвет: {_color}\n" +
                              $"Виден: {IsVisible()}");
        }
    }
}
