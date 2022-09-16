using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BulletHell
{
    internal class YorHa
    {
        private Texture2D yorhaTexture;
        private Vector2 yorhaPosition;
        private float yorhaSpeed;
        private float yorhaDistance;
        private float yorhaHealth = 100;
        private Collision collision;
        private Bullet bullet;
        private float yorhaDamage;

        public Texture2D YorhaTexture { get => yorhaTexture; set => yorhaTexture = value; }
        public Vector2 YorhaPosition { get => yorhaPosition; set => yorhaPosition = value; }
        public float YorhaSpeed { get => yorhaSpeed; set => yorhaSpeed = value; }
        public float YorhaDistance { get => yorhaDistance; set => yorhaDistance = value; }
        public float YorhaHealth { get => yorhaHealth; set => yorhaHealth = value; }
        public Collision Collision { get => collision; set => collision = value; }
        public Bullet Bullet { get => bullet; set => bullet = value; }
        public float YorhaDamage { get => yorhaDamage; set => yorhaDamage = value; }

        public YorHa(int YLocation, int XLocation, float speed)
        {
            YorhaPosition = new Vector2(YLocation, XLocation);
            YorhaSpeed = speed;
        }

        public void addCollision()
        {
            collision = new Collision(yorhaPosition.X, yorhaPosition.Y, yorhaTexture.Width, yorhaTexture.Height);
        }

        public void input(GameTime gameTime, int screenWidth, int screenHeight)
        {
            var kstate = Keyboard.GetState();

            if (kstate.IsKeyDown(Keys.Up))
            {
                yorhaPosition.Y -= yorhaSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }

            if (kstate.IsKeyDown(Keys.Down))
            {
                yorhaPosition.Y += yorhaSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }

            if (kstate.IsKeyDown(Keys.Left))
            {
                yorhaPosition.X -= yorhaSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }

            if (kstate.IsKeyDown(Keys.Right))
            {
                yorhaPosition.X += yorhaSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }
            if (yorhaPosition.X > screenWidth - yorhaTexture.Width / 2)
            {
                yorhaPosition.X = screenWidth - yorhaTexture.Width / 2;
            }
            else if (yorhaPosition.X < yorhaTexture.Width / 2)
            {
                yorhaPosition.X = yorhaTexture.Width / 2;
            }

            if (yorhaPosition.Y > screenHeight - yorhaTexture.Height / 2)
            {
                yorhaPosition.Y = screenHeight - yorhaTexture.Height / 2;
            }
            else if (yorhaPosition.Y < yorhaTexture.Height / 2)
            {
                yorhaPosition.Y = yorhaTexture.Height / 2;
            }
        }

        public void update()
        {
            collision.updateBounds(yorhaPosition.X, yorhaPosition.Y, yorhaTexture.Width, yorhaTexture.Height);
        }
        public void draw(SpriteBatch _spriteBatch)
        {
            _spriteBatch.Draw(
            YorhaTexture,
            YorhaPosition,
            null,
            Color.White,
            0f,
            new Vector2(YorhaTexture.Width / 2, YorhaTexture.Height / 2),
            Vector2.One,
            SpriteEffects.None,
            0f
);
        }
        public void takeDamage(Bullet bullet)
        {
            YorhaHealth -= bullet.Damage;
        }

        public void calculateDirection()
        {

        }
        public void fireGun()
        {

        }
    }
}
