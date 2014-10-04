using System.Drawing;
using ShapeAnimator.Model;

namespace ShapeAnimator.View.Shapes
{
    /// <summary>
    ///     Child class of ShapeSprite. Holds specific information about CircleSprite.
    /// </summary>
    public class CircleSprite : ShapeSprite
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="CircleSprite" /> class.
        /// </summary>
        /// <param name="shape">The shape.</param>
        public CircleSprite(Shape shape) : base(shape)
        {
        }

        /// <summary>
        ///     Draws CircleSprite
        ///     Precondition: None.
        ///     Postcondition: The CircleSprite has now been painted on g at the specified x and y.
        /// </summary>
        /// <param name="g">The graphics object to draw the shape on</param>
        public override void Paint(Graphics g)
        {
            base.Paint(g);

            var yellowBrush = new SolidBrush(Color.Yellow);

            g.FillEllipse(yellowBrush, this.TheShape.X, this.TheShape.Y, 100, 100);
        }
    }
}