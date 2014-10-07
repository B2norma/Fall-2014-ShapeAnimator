using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using ShapeAnimator.Properties;
using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model
{
    /// <summary>
    ///     Manages the collection of shapeList on the Canvas.
    /// </summary>
    public class ShapeManager
    {
        #region Instance variables

        private PictureBox canvas;
        private readonly Random randomizer;
        private readonly List<Shape> shapeList;
        public const int  CanvasHeight = 480;
        public const int CanvasWidth = 720;

        #endregion

        

        #region Constructors

        public ShapeManager()
        {
            
        }
        /// <summary>
        ///     Initializes a new instance of the <see cref="ShapeManager" /> class.
        ///     Precondition: pictureBox != null
        ///     Postcondition: Canvas = pictureBox.
        /// </summary>
        /// <param name="pictureBox">The picture box that will be drawing on</param>
        public ShapeManager(PictureBox pictureBox)
        {
            if (pictureBox == null)
            {
                throw new ArgumentNullException("pictureBox", Resources.PictureBoxNullMessage);
            }

            this.canvas = pictureBox;
            this.shapeList = new List<Shape>();
            this.randomizer = new Random();
            
        }

        #endregion

        /// <summary>
        ///     Places the numberOfShapesToPlaceOnCanvas on the Canvas.
        ///     Precondition: None
        ///     Postcondition: The number of shapes on the Canvas equals numberOfShapesToPlaceOnCanvas.
        /// </summary>
        /// <param name="numberOfShapesToPlaceOnCanvas">The number of shapes to be placed on the Canvas</param>
        public void PlaceShapesOnCanvas(int numberOfShapesToPlaceOnCanvas)
        {
           this.shapeList.Clear();

            for (int i = 0; i < numberOfShapesToPlaceOnCanvas; i++)
            {
                Thread.Sleep(10);

                this.placeTheNumberOfShapesToPlaceOnCanvasAtRandomLocationsOnCanvas();
            }
        }

        private void placeTheNumberOfShapesToPlaceOnCanvasAtRandomLocationsOnCanvas()
        {
            this.shapeList.Add(ShapeFactory.GetRandomShape());
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
                    currShape.Move();
                    currShape.Paint(g);
                }
            }
        }
    }
}