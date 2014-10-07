using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model
{
    public class StripedRectangle : Rectangle
    {
        public StripedRectangle()
        {
            this.Sprite = new StripedRectangleSprite();
            this.Sprite.X = this.Randomizer.Next(0, ShapeManager.CanvasWidth - this.Sprite.XLimit);
            this.Sprite.Y = this.Randomizer.Next(0, ShapeManager.CanvasHeight - this.Sprite.YLimit);
            this.YSpeed = this.Randomizer.Next(1, 6);
        }
    }
}