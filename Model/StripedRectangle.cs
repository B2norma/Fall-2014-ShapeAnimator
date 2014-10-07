using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model
{
    class StripedRectangle : Rectangle
    {

        public StripedRectangle() : base()
        {
            this.sprite = new StripedRectangleSprite();
        }
    }
}
