using System;
using System.Drawing;
using ShapeAnimator.Model;

namespace ShapeAnimator.View.Shapes
{
    /// <summary>
    ///     An abstract class ShapeSprite that is the parent of the other sprite classes.
    /// </summary>
    public abstract class ShapeSprite
    {

        /// <summary>
        ///     The shape
        /// </summary>
        public Shape TheShape;

        private readonly Random randomizer;

        /// <summary>
        ///     Prevents a default instance of the <see cref="ShapeSprite" /> class from being created.
        /// </summary>
        private ShapeSprite()
        {
            this.TheShape = null;
            this.randomizer = null;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ShapeSprite" /> class.
        ///     Precondition: shape != null
        ///     Postcondition: TheShape = shape; randomizer = new Random;
        /// </summary>
        /// <param name="shape">The shape.</param>
        /// <exception cref="System.ArgumentNullException">shape</exception>
        protected ShapeSprite(Shape shape) : this()
        {
            if (shape == null)
            {
                throw new ArgumentNullException("shape");
            }

            this.TheShape = shape;
            this.randomizer = new Random();
        }

        /// <summary>
        ///     Paints the specified graphics object.
        ///     Precondition: g != null
        /// </summary>
        /// <param name="g">The graphics object.</param>
        /// <exception cref="System.ArgumentNullException">g</exception>
        public virtual void Paint(Graphics g)
        {
            if (g == null)
            {
                throw new ArgumentNullException("g");
            }
        }

        /// <summary>
        ///     Moves The shape in a random x and y direction.
        ///     Precondition: None
        ///     Postcondition: ShapeSprite is moved to new xy location.
        /// </summary>
        public void Move()
        {
            this.TheShape.X += this.randomizer.Next(-5, 6);
            this.TheShape.Y += this.randomizer.Next(-5, 6);
        }
    }
}