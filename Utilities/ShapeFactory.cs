using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using ShapeAnimator.Model;

namespace ShapeAnimator.Utilities
{
    /// <summary>
    ///     A static class that contains the utility method getRandomShape().
    /// </summary>
    public static class ShapeFactory
    {

        private enum ShapeType
        {
            Circle,
            Rectangle,
            StripedRectangle
        };

        private static List<ShapeType> shapes;
        private static readonly Random Rand;

        static ShapeFactory()
        {
            shapes = new List<ShapeType>();
            Rand = new Random();
        }

        /// <summary>
        ///     Returns a Random Shape object.
        /// </summary>
        /// <returns>A random shape.</returns>
        public static Shape GetRandomShape()
        {
            createListOfAllShapeEnums();

            Thread.Sleep(10);

            return generateAndReturnRandomShape();
        }

        private static void createListOfAllShapeEnums()
        {
            shapes = Enum.GetValues(typeof (ShapeType)).Cast<ShapeType>().ToList();
        }

        private static Shape generateAndReturnRandomShape()
        {
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
    }
}