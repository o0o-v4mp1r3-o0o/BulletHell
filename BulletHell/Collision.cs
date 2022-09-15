using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletHell
{
    internal class Collision
    {
        public Rectangle _bounds;
        public float xPos, yPos;
        public int width, height;
        public Collision(float xPos, float yPos, int width, int height)
        {
            this.xPos = xPos;
            this.yPos = yPos;
            this.width = width;
            this.height = height;
            _bounds = new Rectangle((int)xPos, (int)yPos, width, height);
        }

        public void updateBounds(float xPos, float yPos, int width, int height)
        {
            _bounds.X = (int)xPos;
            _bounds.Y = (int)yPos;
        }
        public bool isCollision(Bullet bullet, List<Collision> checkCollidedEntities, List<Bullet> bullets)
        {
            if(isTouchingBottom(bullet) || isTouchingLeft(bullet) || isTouchingRight(bullet) || isTouchingTop(bullet))
            {
                System.Diagnostics.Debug.WriteLine("collided!");
                return true;
            }
            return false;
        }
        public bool isTouchingLeft(Bullet bullet)
        {
            return _bounds.Right > bullet.Collision._bounds.Left &&
                _bounds.Left < bullet.Collision._bounds.Left &&
                _bounds.Bottom > bullet.Collision._bounds.Top &&
                _bounds.Top < bullet.Collision._bounds.Bottom;
        }
        public bool isTouchingRight(Bullet bullet)
        {
            return _bounds.Left > bullet.Collision._bounds.Right &&
                _bounds.Right < bullet.Collision._bounds.Right &&
                _bounds.Bottom > bullet.Collision._bounds.Top &&
                _bounds.Top < bullet.Collision._bounds.Bottom;
        }
        public bool isTouchingTop(Bullet bullet)
        {
            return _bounds.Right > bullet.Collision._bounds.Left &&
                _bounds.Left < bullet.Collision._bounds.Right &&
                _bounds.Bottom > bullet.Collision._bounds.Top &&
                _bounds.Top < bullet.Collision._bounds.Top;
        }
        public bool isTouchingBottom(Bullet bullet)
        {
            return _bounds.Right > bullet.Collision._bounds.Left &&
                _bounds.Left < bullet.Collision._bounds.Right &&
                _bounds.Bottom > bullet.Collision._bounds.Bottom &&
                _bounds.Top < bullet.Collision._bounds.Bottom;
        }
    }
}
