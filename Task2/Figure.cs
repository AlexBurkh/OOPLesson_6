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
        protected Boolean _visible;

        public Boolean IsVisible()
        {
            return _visible;
        }
        public void ChangeColor(Color newColor)
        {
            _color = newColor;
        }
        public abstract void MoveX(Int32 shift);
        public abstract void MoveY(Int32 shift);
    }
}
