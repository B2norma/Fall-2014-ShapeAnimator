using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model
{
    class Rectangle : Shape
    {
        public Rectangle() : base()
        {
            this.sprite = new RectangleSprite();
        }
    }
}
