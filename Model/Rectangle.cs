using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model
{
    /// <summary>
    ///     A class derived from Shape that hold specific data for the Rectangle shape.
    /// </summary>
    public class Rectangle : Shape
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Rectangle" /> class.
        /// </summary>
        public Rectangle()
        {
            this.Sprite = new RectangleSprite();
            this.SetRandomXandYLocation();
            this.GetRandomSpeedAndRandomDirection();
        }

        /// <summary>
        /// Gets the random speed and random direction.
        /// Precondition: None
        /// Postcondition: Shape has a random speed and direction.
        /// </summary>
        protected void GetRandomSpeedAndRandomDirection()
        {
            this.YSpeed = this.Randomizer.Next(1, 6) * this.ShapeDirection[this.Randomizer.Next(0, 2)];
        }

        /// <summary>
        ///    Moves the shape in a random direction at a random speed on the y axis until contact with canvas limit then direction is reversed.
        ///    Precondition: None
        ///    Postcondition: Shape is moved to new y location.
        /// </summary>
        public override void Move()
        {
            if (this.moveKeepsShapeWithinCanvasLimits())
            {
                this.moveAtCurrSpeed();
            }
            else
            {
                this.changeDirection();
            }
        }

        private void changeDirection()
        {
            this.YSpeed = this.YSpeed*-1;
            this.Move();
        }

        private void moveAtCurrSpeed()
        {
            this.Sprite.Y = this.Y + this.YSpeed;
        }

        private bool moveKeepsShapeWithinCanvasLimits()
        {
            return this.Y + this.YSpeed > 0 && this.Y + this.YSpeed < ShapeManager.CanvasHeight - this.Sprite.YLimit;
        }
    }
}