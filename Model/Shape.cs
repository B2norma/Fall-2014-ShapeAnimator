using System;
using System.Drawing;
using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model
{
    /// <summary>
    ///     Holds information about the shape object
    /// </summary>
    public class Shape
    {
        #region Instance variables

        /// <summary>
        ///     The sprite
        /// </summary>
        public readonly ShapeSprite Sprite;

        private Point location;

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the x location of the shape.
        /// </summary>
        /// <value>
        ///     The x.
        /// </value>
        public int X
        {
            get { return this.location.X; }
            set { this.location.X = value; }
        }

        /// <summary>
        ///     Gets or sets the y location of the shape.
        /// </summary>
        /// <value>
        ///     The y.
        /// </value>
        public int Y
        {
            get { return this.location.Y; }
            set { this.location.Y = value; }
        }

        #endregion

        #region Constructors

        /// <summary>
        ///     Default constructor
        /// </summary>
        private Shape()
        {
        }

        /// <summary>
        ///     Constructs a shape at specified location
        ///     Precondition: location != null
        ///     Postcondition: X == location.X; Y == location.Y
        /// </summary>
        /// <param name="location">Location to create shape</param>
        /// <exception cref="System.ArgumentNullException">location</exception>
        public Shape(Point location) : this()
        {
            if (location == null)
            {
                throw new ArgumentNullException("location");
            }

            this.location = location;
        }

        /// <summary>
        ///     Constructs a shape specified x,y location
        ///     Precondition: None
        ///     Postcondition: X == x; Y == y
        /// </summary>
        /// <param name="x">The x coordinate</param>
        /// <param name="y">The y coordinate</param>
        public Shape(int x, int y) : this()
        {
            this.location = new Point(x, y);
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Shape" /> class.
        ///     Precondition: aShapeSprite != null
        ///     Postcondition: Sprite = aShapeSprite
        /// </summary>
        /// <param name="aShapeSprite">A shape sprite.</param>
        /// <exception cref="System.ArgumentNullException">aShapeSprite</exception>
        public Shape(ShapeSprite aShapeSprite) : this()
        {
            if (aShapeSprite == null)
            {
                throw new ArgumentNullException("aShapeSprite");
            }
            this.Sprite = aShapeSprite;
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Draws a shape
        ///     Precondition: g != NULL
        /// </summary>
        /// <param name="g">The graphics object to draw the shape one</param>
        public void Paint(Graphics g)
        {
            if (g == null)
            {
                throw new ArgumentNullException("g");
            }

            this.Sprite.Paint(g);
        }

        #endregion
    }
}