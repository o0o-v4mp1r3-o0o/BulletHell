using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletHell.Model
{
    internal class BulletA : BulletBase
    {
        public BulletA()
        {
            Damage = 1;
            Position = new Vector2(0.0f, 0.0f);
            Speed = 0.0f;
            Direction = 0.0f;
            Team = 0;
        }

        //public void update(int screenWidth, int screenHeight, BulletA bullet, List<BulletA> bullets)
        //{
        //    //collision.updateBounds(bulletPosition.X, bulletPosition.Y, bulletTexture.Width, bulletTexture.Height);
        //    //if (bulletPosition.X > screenWidth || bulletPosition.X < bulletTexture.Width / 2 ||
        //    //        bulletPosition.Y > screenHeight || bulletPosition.Y < bulletTexture.Height / 2)
        //    //{
        //    //    isOffscreen = true;
        //    //}

        //}
        //public void draw(SpriteBatch _spriteBatch)
        //{
        //    _spriteBatch.Draw(
        //    bulletTexture, bulletPosition, null, Color.White, 0f, new Vector2(bulletTexture.Width / 2, bulletTexture.Height / 2), Vector2.One, SpriteEffects.None, 0f);
        //}

        //public void travelDirection(GameTime gameTime)
        //{
        //    bulletPosition.X += x * (float)gameTime.ElapsedGameTime.TotalSeconds;
        //    bulletPosition.Y += y * (float)gameTime.ElapsedGameTime.TotalSeconds;
        //}

        //public void calculateDirection()
        //{
        //    if (direction < 90)
        //    {
        //        x = (float)Math.Cos(direction) * bulletSpeed;
        //        y = (float)Math.Sin(direction) * bulletSpeed * -1;
        //    }
        //    else if (direction >= 90 && direction < 180)
        //    {
        //        x = (float)Math.Cos(180 - direction) * bulletSpeed * -1;
        //        y = (float)Math.Sin(180 - direction) * bulletSpeed * -1;
        //    }
        //    else if (direction >= 180 && direction < 270)
        //    {
        //        x = (float)Math.Cos(270 - direction) * bulletSpeed * -1;
        //        y = (float)Math.Sin(270 - direction) * bulletSpeed;
        //    }
        //    else
        //    {
        //        x = (float)Math.Cos(360 - direction) * bulletSpeed;
        //        y = (float)Math.Sin(360 - direction) * bulletSpeed;
        //    }
        //}

        //public void destroySelf(BulletA bullet, List<BulletA> bullets)
        //{
        //    bullets.Remove(bullet);
        //    bullet = null;
        //}
        //public bool isOnSameTeam(BulletA bullet1, BulletA bullet2)
        //{
        //    return bullet1.BulletTeam == bullet2.BulletTeam;
        //}
        //public bool isOnSameTeam(Bullet bullet, LivingEntity entity)
        //{
        //    return bullet.BulletTeam == entity.Team;
        //}
    }
}
