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

        
        

        #region Properties

        /// <summary>
        ///     Gets or sets the x location of the shape.
        /// </summary>
        /// <value>
        ///     The x.
        /// </value>

        public int X
        {
            get;
            set;
        }

        /// <summary>
        ///     Gets or sets the y location of the shape.
        /// </summary>
        /// <value>
        ///     The y.
        /// </value>

        public int Y
        {
            get;
            set;
        }

        public abstract int X_LIMIT
        {
            get;
        }

        public abstract int Y_LIMIT
        {
            get;
        }

        #endregion

        

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
    }
}