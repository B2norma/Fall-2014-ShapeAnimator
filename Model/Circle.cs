using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model
{
    /// <summary>
    ///     A class derived from Shape that hold specific data for the Circle shape.
    /// </summary>
    public class Circle : Shape
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Circle" /> class.
        /// </summary>
        public Circle()
        {
            this.Sprite = new CircleSprite();
            this.SetRandomXandYLocation();
            this.getRandomSpeed();
        }

        private void getRandomSpeed()
        {
            this.XSpeed = this.Randomizer.Next(1, 6)*this.ShapeDirection[this.Randomizer.Next(0, 2)];
        }

        /// <summary>
        ///    Moves the shape in a random direction at a random speed on the x axis until contact with canvas limit then direction is reversed.
        ///    Precondition: None
        ///    Postcondition: Shape is moved to new x location.
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
            this.XSpeed = this.XSpeed*-1;
            this.Move();
        }

        private void moveAtCurrSpeed()
        {
            this.Sprite.X = this.X + this.XSpeed;
        }

        private bool moveKeepsShapeWithinCanvasLimits()
        {
            return this.X + this.XSpeed > 0 && this.X + this.XSpeed < ShapeManager.CanvasWidth - this.Sprite.XLimit;
        }
    }
}