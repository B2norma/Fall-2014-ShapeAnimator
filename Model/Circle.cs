using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model
{
    
    public class Circle : Shape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        public Circle()
        {
            this.Sprite = new CircleSprite();
            this.Sprite.X = this.Randomizer.Next(0, ShapeManager.CanvasWidth - this.Sprite.XLimit);
            this.Sprite.Y = this.Randomizer.Next(0, ShapeManager.CanvasHeight - this.Sprite.YLimit);
            this.XSpeed = this.Randomizer.Next(1, 6)*this.ShapeDirection[this.Randomizer.Next(0,2)];
        }

        /// <summary>
        ///     Moves The shape in a random x and y direction.
        ///     Precondition: None
        ///     Postcondition: ShapeSprite is moved to new xy location.
        /// </summary>
        public override void Move()
        {
            if (this.X + this.XSpeed > 0 && this.X + this.XSpeed < ShapeManager.CanvasWidth - this.Sprite.XLimit)
            {
                this.Sprite.X = this.X + this.XSpeed;
            }
            else
            {
                this.XSpeed = this.XSpeed*-1;
                this.Move();
            }
        }
    }
}