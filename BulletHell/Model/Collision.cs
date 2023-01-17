using BulletHell.Model;
using Microsoft.Xna.Framework;

namespace BulletHell
{
    internal abstract class Collision : Entity
    {
        public Rectangle _bounds;

        public void updateBounds(float xPos, float yPos)
        {
            _bounds.X = (int)xPos;
            _bounds.Y = (int)yPos;
        }
        public bool isCollision(BulletBase bullet)
        {
            if (_bounds.Intersects(bullet._bounds))
            {
                System.Diagnostics.Debug.WriteLine("Collision Detected!");
                return true;
            }
            return false;
        }
    }
}
