using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletHell
{
    internal class Bullet
    {
        private float damage;
        private Texture2D bulletTexture;
        private Vector2 bulletPosition;
        private float bulletSpeed;
        private float direction;
        private float x, y;
        private Collision collision;
        private bool isOffscreen;

        public Bullet(float damage, Vector2 bulletPosition, float bulletSpeed, float direction)
        {
            this.damage = damage;
            this.bulletPosition = bulletPosition;
            this.bulletSpeed = bulletSpeed;
            this.direction = (float)(direction * (Math.PI / 180.0));
            calculateDirection();
        }

        public float Damage { get => damage; set => damage = value; }
        public Texture2D BulletTexture { get => bulletTexture; set => bulletTexture = value; }
        public Vector2 BulletPosition { get => bulletPosition; set => bulletPosition = value; }
        public float BulletSpeed { get => bulletSpeed; set => bulletSpeed = value; }
        public Collision Collision { get => collision; set => collision = value; }
        public bool IsOffscreen { get => isOffscreen; set => isOffscreen = value; }

        public void addCollision()
        {
            collision = new Collision(bulletPosition.X, bulletPosition.Y, bulletTexture.Width, bulletTexture.Height);

        }

        public void update(int screenWidth, int screenHeight, Bullet bullet, List<Collision> checkCollidedEntities, List<Bullet> bullets)
        {
            collision.updateBounds(bulletPosition.X, bulletPosition.Y, bulletTexture.Width, bulletTexture.Height);
            if ((bulletPosition.X > screenWidth) || (bulletPosition.X < bulletTexture.Width / 2) || 
                    (bulletPosition.Y > screenHeight) || (bulletPosition.Y < bulletTexture.Height / 2))
            {
                isOffscreen = true;
            }
            
        }
        public void draw(SpriteBatch _spriteBatch)
        {
            _spriteBatch.Draw(
            bulletTexture,bulletPosition,null,Color.White,0f,new Vector2(bulletTexture.Width / 2, bulletTexture.Height / 2),Vector2.One,SpriteEffects.None,0f);
        }

        public void travelDirection(GameTime gameTime)
        {
            bulletPosition.X += x * (float)gameTime.ElapsedGameTime.TotalSeconds;
            bulletPosition.Y += y * (float)gameTime.ElapsedGameTime.TotalSeconds;
        }

        public void calculateDirection()
        {
            if (direction < 90)
            {
                x = (float)Math.Cos(direction) * bulletSpeed;
                y = (float)Math.Sin(direction) * bulletSpeed*-1;
            }
            else if(direction>=90 && direction < 180)
            {
                x = (float)Math.Cos(180 - direction) * bulletSpeed*-1;
                y = (float)Math.Sin(180 - direction) * bulletSpeed*-1;
            }
            else if(direction >= 180 && direction < 270)
            {
                x = (float)Math.Cos(270-direction) * bulletSpeed*-1;
                y = (float)Math.Sin(270-direction) * bulletSpeed;
            }
            else
            {
                x = (float)Math.Cos(360 - direction) * bulletSpeed;
                y = (float)Math.Sin(360 - direction) * bulletSpeed;
            }
        }

        public void destroySelf(Bullet bullet, List<Collision> checkCollidedEntities, List<Bullet> bullets)
        {
            checkCollidedEntities.Remove(bullet.Collision);
            bullets.Remove(bullet);
            bullet = null;
        }
    }
}
