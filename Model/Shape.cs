using System;
using System.Drawing;
using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model
{
    /// <summary>
    ///     Holds information about the shape object
    /// </summary>
    public abstract class Shape
    {
        #region Instance variables

        /// <summary>
        ///     The sprite
        /// </summary>
        public ShapeSprite sprite;
        protected readonly Random randomizer;

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
            get { return this.sprite.X; }
        }

        /// <summary>
        ///     Gets or sets the y location of the shape.
        /// </summary>
        /// <value>
        ///     The y.
        /// </value>

        public int Y
        {
            get { return this.sprite.Y; }
        }

        #endregion

        #region Constructors

        /// <summary>
        ///     Default constructor
        /// </summary>
        protected Shape()
        {
            this.randomizer = new Random();
            this.sprite = null;
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
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Moves The shape in a random x and y direction.
        ///     Precondition: None
        ///     Postcondition: ShapeSprite is moved to new xy location.
        /// </summary>
        public void Move()
        {

            this.sprite.X = this.X + this.randomizer.Next(-5, 6);
            this.sprite.Y = this.Y + this.randomizer.Next(-5, 6);
        }

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

            this.sprite.Paint(g);
        }

        #endregion
    }
}