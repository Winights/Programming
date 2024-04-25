using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes.Geometry
{
    /// <summary>
    /// Выполняет проверку о пересечении/столкновении геометрических фигур.
    /// </summary>
    public class CollisionManager
    {
        public bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            double deltaX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            double deltaY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);

            double halfWidthSum = (rectangle1.Width + rectangle2.Width) / 2;
            double halfLengthSum = (rectangle1.Length + rectangle2.Length) / 2;

            return deltaX < halfWidthSum && deltaY < halfLengthSum;
        }
        public bool IsCollision(Ring ring1, Ring ring2)
        {
            double sumExternalRadius = ring1.ExternalRadius + ring2.ExternalRadius;
            double distanceX = Math.Sqrt(Math.Pow(ring1.Center.X - ring2.Center.X, 2));
            double distanceY = Math.Sqrt(Math.Pow(ring1.Center.Y - ring2.Center.Y, 2));
            double distance = distanceX + distanceY;
            return distance < sumExternalRadius;
        }
    }
}
