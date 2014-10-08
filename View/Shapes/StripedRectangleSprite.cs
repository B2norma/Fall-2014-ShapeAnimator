using System.Drawing;
using System.Drawing.Drawing2D;
using ShapeAnimator.Utilities;

namespace ShapeAnimator.View.Shapes
{
    /// <summary>
    ///     Child class of ShapeSprite. Holds specific information about StripedRectangleSprite.
    /// </summary>
    public class StripedRectangleSprite : RectangleSprite
    {
        private readonly HatchBrush myHatchBrush;

        /// <summary>
        ///     Initializes a new instance of the <see cref="StripedRectangleSprite" /> class.
        /// </summary>
        public StripedRectangleSprite()
        {
            this.myHatchBrush = new HatchBrush(HatchStyle.Vertical, ColorFactory.GetRandomColor(),
                ColorFactory.GetRandomColor());
        }

        /// <summary>
        ///     Draws a StripedRectangleSprite
        ///     Postcondition: The StripedRectangleSprite has now been painted on g at the specified x and y.
        /// </summary>
        /// <param name="g">The graphics object to draw the shape one</param>
        public override void Paint(Graphics g)
        {
            base.Paint(g);

            g.FillRectangle(this.myHatchBrush, this.X, this.Y, 150, 50);
        }
    }
}