using System.Drawing;
using ShapeAnimator.Utilities;

namespace ShapeAnimator.View.Shapes
{
    /// <summary>
    ///     Child class of ShapeSprite. Holds specific information about CircleSprite.
    /// </summary>
    public class CircleSprite : ShapeSprite
    {
        private readonly Color randomColor;

        /// <summary>
        ///     Initializes a new instance of the <see cref="CircleSprite" /> class.
        /// </summary>
        public CircleSprite()
        {
            this.randomColor = ColorFactory.GetRandomColor();
        }

        /// <summary>
        ///     Returns the x_ limit for CircleSprite.
        /// </summary>
        /// <value>
        ///     The x_ limit.
        /// </value>
        public override int XLimit
        {
            get { return 100; }
        }

        /// <summary>
        ///     Returns the y_ limit for CircleSprite.
        /// </summary>
        /// <value>
        ///     The y_ limit.
        /// </value>
        public override int YLimit
        {
            get { return 100; }
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

            var brush = new SolidBrush(this.randomColor);

            g.FillEllipse(brush, this.X, this.Y, 100, 100);
        }
    }
}