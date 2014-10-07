using System;
using System.Collections.Generic;
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

        protected readonly Random Randomizer;
        protected List<int> ShapeDirection;
        protected ShapeSprite Sprite;
        protected int XSpeed;
        protected int YSpeed;

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
            get { return this.Sprite.X; }
        }

        /// <summary>
        ///     Gets or sets the y location of the shape.
        /// </summary>
        /// <value>
        ///     The y.
        /// </value>
        public int Y
        {
            get { return this.Sprite.Y; }
        }

        #endregion

        #region Constructors

        /// <summary>
        ///     Default constructor
        /// </summary>
        protected Shape()
        {
            this.Randomizer = new Random();
            ShapeDirection = new List<int>(){1,-1};
        }

        /// <summary>
        ///     Constructs a shape specified x,y location
        ///     Precondition: None
        ///     Postcondition: X == x; Y == y
        /// </summary>
        /// <param name="x">The x coordinate</param>
        /// <param name="y">The y coordinate</param>
        protected Shape(int x, int y) : this()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Shape" /> class.
        ///     Precondition: aShapeSprite != null
        ///     Postcondition: Sprite = aShapeSprite
        /// </summary>
        /// <param name="aShapeSprite">A shape sprite.</param>
        /// <exception cref="System.ArgumentNullException">aShapeSprite</exception>
        protected Shape(ShapeSprite aShapeSprite) : this()
        {
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Moves The shape in a random x and y direction.
        ///     Precondition: None
        ///     Postcondition: ShapeSprite is moved to new xy location.
        /// </summary>
        public abstract void Move();
        

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