using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {
            this.Sprite = new RectangleSprite();
            this.Sprite.X = this.Randomizer.Next(0, ShapeManager.CanvasWidth - this.Sprite.XLimit) ;
            this.Sprite.Y = this.Randomizer.Next(0, ShapeManager.CanvasHeight - this.Sprite.YLimit);
            this.YSpeed = this.Randomizer.Next(1, 6) * this.ShapeDirection[this.Randomizer.Next(0, 2)];
        }

        /// <summary>
        ///     Moves The shape in a random x and y direction.
        ///     Precondition: None
        ///     Postcondition: ShapeSprite is moved to new xy location.
        /// </summary>
        public override void Move()
        {
            if (this.Y + this.YSpeed > 0 && this.Y + this.YSpeed < ShapeManager.CanvasHeight - this.Sprite.YLimit)
            {
                this.Sprite.Y = this.Y + this.YSpeed;
            }
            else
            {
                this.YSpeed = this.YSpeed * -1;
                this.Move();
            }
        }
    }
}