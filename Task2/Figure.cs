using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public abstract class Figure
    {
        protected Color _color;
        protected bool _visible;

        public bool IsVisible()
        {
            return _visible;
        }
        public void ChangeColor(Color newColor)
        {
            _color = newColor;
        }
        public abstract void MoveX(int shift);
        public abstract void MoveY(int shift);
        public abstract void Print();
    }
}
