using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeAnimator.Model;

namespace ShapeAnimator.View.Shapes
{
     public static class ShapeFactory
    {
         enum ShapeType { Circle, Rectangle, StripedRectangle };

         private static List<ShapeType> shapes = new List<ShapeType>();
         private static Random rand  = new Random();
        
         public static Shape getRandomShape()
         {
             shapes = Enum.GetValues(typeof(ShapeType)).Cast<ShapeType>().ToList();
             

             switch(rand.Next(shapes.Count))
             {
                 case (int)ShapeType.Circle:
                     {
                         Shape circle = new Circle();
                         return circle;
                     }
                 case (int)ShapeType.Rectangle:
                     {
                         Shape rectangle = new Rectangle();
                         return rectangle;
                     }
                 case (int)ShapeType.StripedRectangle:
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
