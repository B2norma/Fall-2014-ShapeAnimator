using System.Drawing;
using ShapeAnimator.Model;

namespace ShapeAnimator.View.Shapes
{
    /// <summary>
    ///     Child class of ShapeSprite. Holds specific information about RectangleSprite.
    /// </summary>
    public class RectangleSprite : ShapeSprite
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="RectangleSprite" /> class.
        /// </summary>
        /// <param name="shape">The shape.</param>
        public RectangleSprite(Shape shape) : base(shape)
        {
        }

        /// <summary>
        ///     Draws a RectangleSprite.
        ///     Postcondition: The RectangleSprite has now been painted on g at the specified x and y.
        /// </summary>
        /// <param name="g">The graphics object to draw the shape one</param>
        public override void Paint(Graphics g)
        {
            base.Paint(g);

            var redBrush = new SolidBrush(Color.Red);

            g.FillRectangle(redBrush, this.TheShape.X, this.TheShape.Y, 150, 50);
        }
    }
}