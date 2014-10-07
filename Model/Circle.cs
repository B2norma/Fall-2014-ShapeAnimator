using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model
{
    internal class Circle : Shape
    {
        public Circle()
        {
            this.Sprite = new CircleSprite();
        }
    }
}