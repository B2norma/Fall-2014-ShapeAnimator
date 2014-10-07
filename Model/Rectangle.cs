using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model
{
    internal class Rectangle : Shape
    {
        public Rectangle()
        {
            this.Sprite = new RectangleSprite();
        }
    }
}