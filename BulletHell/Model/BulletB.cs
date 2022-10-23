using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletHell.Model
{
    internal class BulletB : BulletBase
    {
        public BulletB()
        {
            Damage = 1;
            Position = new Vector2(0.0f, 0.0f);
            Speed = 0.0f;
            Direction = 0.0f;
            Team = 0;
        }

        public void update(int screenWidth, int screenHeight, BulletA bullet, List<BulletA> bullets)
        {
            calculateDirection();
            //collision.updateBounds(bulletPosition.X, bulletPosition.Y, bulletTexture.Width, bulletTexture.Height);
            //if (bulletPosition.X > screenWidth || bulletPosition.X < bulletTexture.Width / 2 ||
            //        bulletPosition.Y > screenHeight || bulletPosition.Y < bulletTexture.Height / 2)
            //{
            //    isOffscreen = true;
            //}

        }

        /*
         * This is bad. Why is it bad? Think memory leak.
        public void destroySelf(BulletB bullet, List<BulletB> bullets)
        {
            bullets.Remove(bullet);
            bullet = null;
        }
        */

        //public bool isOnSameTeam(BulletBase bullet1, BulletBase bullet2)
        //{
        //    return bullet1.Team == bullet2.Team;
        //}
        //public bool isOnSameTeam(Bullet bullet, LivingEntity entity)
        //{
        //    return bullet.BulletTeam == entity.Team;
        //}
    }
}

