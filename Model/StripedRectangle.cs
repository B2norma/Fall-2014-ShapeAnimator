using ShapeAnimator.View.Shapes;

namespace ShapeAnimator.Model
{
    /// ///
    /// <summary>
    ///     A class derived from Rectangle that hold specific data for the StripedRectangle shape.
    /// </summary>
    public class StripedRectangle : Rectangle
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="StripedRectangle" /> class.
        /// </summary>
        public StripedRectangle()
        {
            this.Sprite = new StripedRectangleSprite();
            this.SetRandomXandYLocation();
            this.GetRandomSpeedAndRandomDirection();
        }

        
    }
}