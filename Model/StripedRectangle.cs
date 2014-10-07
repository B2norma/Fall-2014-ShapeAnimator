using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model
{
    internal class StripedRectangle : Rectangle
    {
        public StripedRectangle()
        {
            this.Sprite = new StripedRectangleSprite();
        }
    }
}