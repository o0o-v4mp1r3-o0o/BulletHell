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
            Team = 1;
        }

        public void setBoundsWidthHeight()
        {
            this._bounds.Width = this.Texture.Width;
            this._bounds.Height = this.Texture.Height;
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

