using System;
using System.Collections.Generic;
using System.Linq;
using ShapeAnimator.Model;

namespace ShapeAnimator.View.Shapes
{
    /// <summary>
    /// A static class that contains the utility method getRandomShape().
    /// </summary>
    public static class ShapeFactory
    {
        private static List<ShapeType> shapes = new List<ShapeType>();
        private static readonly Random Rand = new Random();

        /// <summary>
        /// Returns a Random Shape object.
        /// </summary>
        /// <returns>A random shape.</returns>
        public static Shape GetRandomShape()
        {
            shapes = Enum.GetValues(typeof (ShapeType)).Cast<ShapeType>().ToList();

            switch (Rand.Next(shapes.Count))
            {
                case (int) ShapeType.Circle:
                {
                    Shape circle = new Circle();
                    return circle;
                }
                case (int) ShapeType.Rectangle:
                {
                    Shape rectangle = new Rectangle();
                    return rectangle;
                }
                case (int) ShapeType.StripedRectangle:
                {
                    Shape stripedRectangle = new StripedRectangle();
                    return stripedRectangle;
                }
                default:
                {
                    return null;
                }
            }
        }

        private enum ShapeType
        {
            Circle,
            Rectangle,
            StripedRectangle
        };
    }
}