using System.Drawing;
using System.Drawing.Drawing2D;
using ShapeAnimator.Model;

namespace ShapeAnimator.View.Shapes
{
    /// <summary>
    ///     Child class of ShapeSprite. Holds specific information about StripedRectangleSprite.
    /// </summary>
    public class StripedRectangleSprite : RectangleSprite
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="StripedRectangleSprite" /> class.
        /// </summary>
        /// <param name="shape">The shape.</param>
        public StripedRectangleSprite(Shape shape) : base(shape)
        {
        }

        /// <summary>
        ///     Draws a StripedRectangleSprite
        ///     Postcondition: The StripedRectangleSprite has now been painted on g at the specified x and y.
        /// </summary>
        /// <param name="g">The graphics object to draw the shape one</param>
        public override void Paint(Graphics g)
        {
            base.Paint(g);

            var myHatchBrush =
                new HatchBrush(HatchStyle.Vertical, Color.Blue, Color.GreenYellow);

            g.FillRectangle(myHatchBrush, this.TheShape.X, this.TheShape.Y, 150, 50);
        }
    }
}