﻿using System.Drawing;
using ShapeAnimator.Utilities;

namespace ShapeAnimator.View.Shapes
{
    /// <summary>
    ///     Child class of ShapeSprite. Holds specific information about RectangleSprite.
    /// </summary>
    /// t
    public class RectangleSprite : ShapeSprite
    {
        private readonly Color randomColor;

        /// <summary>
        ///     Initializes a new instance of the <see cref="RectangleSprite" /> class.
        /// </summary>
        public RectangleSprite()
        {
            this.randomColor = ColorFactory.GetRandomColor();
        }

        /// <summary>
        ///     Gets the x_ limit.
        /// </summary>
        /// <value>
        ///     The x_ limit.
        /// </value>
        public override int XLimit
        {
            get { return 150; }
        }

        /// <summary>
        ///     Gets the y_ limit.
        /// </summary>
        /// <value>
        ///     The y_ limit.
        /// </value>
        public override int YLimit
        {
            get { return 50; }
        }

        /// <summary>
        ///     Draws a RectangleSp
        ///     rite.
        ///     Postcondition: The RectangleSprite has now been painted on g at the specified x and y.
        /// </summary>
        /// <param name="g">The graphics object to draw the shape one</param>
        public override void Paint(Graphics g)
        {
            base.Paint(g);

            var redBrush = new SolidBrush(this.randomColor);

            g.FillRectangle(redBrush, this.X, this.Y, 150, 50);
        }
    }
}