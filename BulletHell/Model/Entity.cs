using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace BulletHell.Model
{
    internal abstract class Entity : GameObject
    {
        protected Texture2D texture;
        protected float speed;
        protected float direction;
        protected float distance;
        protected float x, y;
        protected bool isDead;
        // These are given by texture
        //private Rectangle _bounds;
        //private int width, height;

        public Texture2D Texture { get => texture; set => texture = value; }
        public float Speed { get => speed; set => speed = value; }
        public float Direction { get => direction; set => direction = value * (MathHelper.Pi / 180); }
        public float Distance { get => distance; set => distance = value; }
        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }

        public bool IsDead { get => isDead; set => isDead = value; }
        //public Rectangle Bounds { get => _bounds; set => _bounds = value; }
        //public int Width { get => width; set => width = value; }
        //public int Height { get => height; set => height = value; }

        public abstract void update(GameTime gameTime);

        public void draw(SpriteBatch _spriteBatch)
        {
            _spriteBatch.Draw(
            Texture,
            Position,
            null,
            Color.White,
            0f,
            new Vector2(Texture.Width / 2, Texture.Height / 2),
            Vector2.One,
            SpriteEffects.None,
            0f);

            //foreach (Bullet bullet in firedBullets)
            //{
            //    _spriteBatch.Draw(
            //bullet.BulletTexture, bullet.BulletPosition, null, Color.White, 0f, new Vector2(bullet.BulletTexture.Width / 2, bullet.BulletTexture.Height / 2), Vector2.One, SpriteEffects.None, 0f);
            //}
        }

        //public void updateBounds(float xPos, float yPos)
        //{
        //    Texture.Bounds.Intersects()
        //    Rectangle tempBounds = Texture.Bounds;
        //    tempBounds.X = (int)xPos;
        //    tempBounds.Y = (int)yPos;
        //    Texture.Bounds = tempBounds;
        //}
        //public bool isCollision(BulletBase bullet)
        //{
        //    return Texture.Bounds.Intersects(bullet.Texture.Bounds);
        //    //if (isTouchingBottom(bullet) || isTouchingLeft(bullet) || isTouchingRight(bullet) || isTouchingTop(bullet))
        //    //{
        //    //    System.Diagnostics.Debug.WriteLine("collided!");
        //    //    return true;
        //    //}
        //    //return false;
        //}
        //public bool isTouchingLeft(BulletBase bullet)
        //{
        //    return Texture.Bounds.Right > bullet.Texture.Bounds.Left &&
        //        Texture.Bounds.Left < bullet.Texture.Bounds.Left &&
        //        Texture.Bounds.Bottom > bullet.Texture.Bounds.Top &&
        //        Texture.Bounds.Top < bullet.Texture.Bounds.Bottom;
        //}
        //public bool isTouchingRight(BulletBase bullet)
        //{
        //    return Texture.Bounds.Left > bullet.Texture.Bounds.Right &&
        //        Texture.Bounds.Right < bullet.Texture.Bounds.Right &&
        //        Texture.Bounds.Bottom > bullet.Texture.Bounds.Top &&
        //        Texture.Bounds.Top < bullet.Texture.Bounds.Bottom;
        //}
        //public bool isTouchingTop(BulletBase bullet)
        //{
        //    return Texture.Bounds.Right > bullet.Texture.Bounds.Left &&
        //        Texture.Bounds.Left < bullet.Texture.Bounds.Right &&
        //        Texture.Bounds.Bottom > bullet.Texture.Bounds.Top &&
        //        Texture.Bounds.Top < bullet.Texture.Bounds.Top;
        //}
        //public bool isTouchingBottom(BulletBase bullet)
        //{
        //    return Texture.Bounds.Right > bullet.Texture.Bounds.Left &&
        //        Texture.Bounds.Left < bullet.Texture.Bounds.Right &&
        //        Texture.Bounds.Bottom > bullet.Texture.Bounds.Bottom &&
        //        Texture.Bounds.Top < bullet.Texture.Bounds.Bottom;
        //}
    }
}
