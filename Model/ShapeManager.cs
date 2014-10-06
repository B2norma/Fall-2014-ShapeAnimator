using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ShapeAnimator.Properties;
using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model
{
    /// <summary>
    ///     Manages the collection of shapeList on the canvas.
    /// </summary>
    public class ShapeManager
    {
        #region Instance variables

        private const int RectangleWidthLimit = 151;
        private const int RectangleHeightLimit = 51;
        private const int CircleLimit = 101;
        private readonly PictureBox canvas;
        private readonly Random randomizer;
        private readonly List<Shape> shapeList;

        #endregion

        #region Constructors

        /// <summary>
        ///     Prevents a default instance of the <see cref="ShapeManager" /> class from being created.
        /// </summary>
        private ShapeManager()
        {
            this.shapeList = new List<Shape>();
            this.randomizer = new Random();
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ShapeManager" /> class.
        ///     Precondition: pictureBox != null
        ///     Postcondition: canvas = pictureBox.
        /// </summary>
        /// <param name="pictureBox">The picture box that will be drawing on</param>
        public ShapeManager(PictureBox pictureBox) : this()
        {
            if (pictureBox == null)
            {
                throw new ArgumentNullException("pictureBox", Resources.PictureBoxNullMessage);
            }

            this.canvas = pictureBox;
        }

        #endregion

        /// <summary>
        ///     Places the numberOfShapesToPlaceOnCanvas on the canvas.
        ///     Precondition: None
        ///     Postcondition: The number of shapes on the canvas equals numberOfShapesToPlaceOnCanvas.
        /// </summary>
        /// <param name="numberOfShapesToPlaceOnCanvas">The number of shapes to be placed on the canvas</param>
        public void PlaceShapesOnCanvas(int numberOfShapesToPlaceOnCanvas)
        {
            for (int i = 0; i < numberOfShapesToPlaceOnCanvas; i++)
            {
                Thread.Sleep(10);

                this.placeTheNumberOfShapesToPlaceOnCanvasAtRandomLocationsOnCanvas();
            }
        }

        private void placeTheNumberOfShapesToPlaceOnCanvasAtRandomLocationsOnCanvas()
        {
            ShapeSprite randomShape = this.getRandomShape();

            this.shapeList.Add(new Shape(randomShape));
        }

        private ShapeSprite getRandomShape()
        {
            int rectangleX = this.randomizer.Next(this.canvas.Width - RectangleWidthLimit);
            int rectangleY = this.randomizer.Next(this.canvas.Height - RectangleHeightLimit);
            int circleX = this.randomizer.Next(this.canvas.Width - CircleLimit);
            int circleY = this.randomizer.Next(this.canvas.Height - CircleLimit);

            var shapeSpriteList = new List<ShapeSprite>();

            shapeSpriteList.Clear();

            ShapeSprite rectangle = new RectangleSprite(new Shape(rectangleX, rectangleY));
            ShapeSprite stripedRectangle = new StripedRectangleSprite(new Shape(rectangleX, rectangleY));
            ShapeSprite circle = new CircleSprite(new Shape(circleX, circleY));

            shapeSpriteList.Add(rectangle);
            shapeSpriteList.Add(stripedRectangle);
            shapeSpriteList.Add(circle);

            return shapeSpriteList[this.randomizer.Next(3)];
        }

        /// <summary>
        ///     Moves the shapes in shapeList around and the calls the Shape::Paint method to draw the the shapes in shapeList.
        ///     Precondition: g != null
        ///     Postcondition: The shapes in shapeList move and are painted.
        /// </summary>
        /// <param name="g">The graphics object to draw on</param>
        public void Update(Graphics g)
        {
            if (g == null)
            {
                throw new ArgumentNullException("g");
            }

            if (this.shapeList != null)
            {
                foreach (Shape currShape in this.shapeList)
                {
                    currShape.Sprite.Move();
                    currShape.Paint(g);
                }
            }
        }
    }
}