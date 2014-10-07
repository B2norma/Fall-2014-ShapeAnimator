using System.Drawing;
using ShapeAnimator.Model;

namespace ShapeAnimator.View.Shapes
{
    /// <summary>
    ///     Child class of ShapeSprite. Holds specific information about CircleSprite.
    /// </summary>
    public class CircleSprite : ShapeSprite
    {
        public override int X_LIMIT
        {
            get
            {
                return 100;
            }
        }

        public override int Y_LIMIT
        {
            get
            {
                return 100;
            }
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

            g.FillEllipse(yellowBrush, this.X, this.Y, 100, 100);
        }
    }
}