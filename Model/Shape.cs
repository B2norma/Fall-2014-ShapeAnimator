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
            this.ShapeDirection = new List<int> {1, -1};
        }

        #endregion

        #region Methods

        /// <summary>
        /// Sets the random x and y location.
        /// Preconditions: None.
        /// Postcondition: the Shape now has a random X and Y.
        /// </summary>
        protected void SetRandomXandYLocation()
        {
            this.Sprite.X = this.Randomizer.Next(0, ShapeManager.CanvasWidth - this.Sprite.XLimit);
            this.Sprite.Y = this.Randomizer.Next(0, ShapeManager.CanvasHeight - this.Sprite.YLimit);
        }

        /// <summary>
        ///     Moves The shape at a random speed in the x or y direction.
        ///     Precondition: None
        ///     Postcondition: ShapeSprite is moved in a x or y direction equal the the speed.
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