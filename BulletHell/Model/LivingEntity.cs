using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BulletHell.Model
{
    internal class LivingEntity : Entity
    {
        private float health;
        private float firingRate;
        private float aimDirection;
        private int team;
        /* Damage doesen't go here.
         * Why?
         * Who owns damage? 
         */
        //private int damage;
        
        public float Health { get => health; set => health = value; }
        public float FiringRate { get => firingRate; set => firingRate = value; }
        public float AimDirection { get => aimDirection; set => aimDirection = value; }
        public int Team { get => team; set => team = value; }

        public override void update(GameTime gameTime)
        {
            //for (int i = 0; i < firedBullets.Count; i++)
            //{
            //    firedBullets[i].travelDirection(gameTime);
            //    firedBullets[i].update(screenWidth, screenHeight, firedBullets[i], firedBullets);
            //    if (firedBullets[i].IsOffscreen)
            //    {
            //        firedBullets[i].destroySelf(firedBullets[i], firedBullets);
            //        i--;
            //    }
            //}

            //if ((float)gameTime.TotalGameTime.TotalSeconds - gameTimer > FiringRate)
            //{
            //    gameTimer = (float)gameTime.TotalGameTime.TotalSeconds;
            //    fireGun();
            //}
        }

        public void takeDamage(BulletBase bullet)
        {
            Health -= bullet.Damage;
            System.Diagnostics.Debug.WriteLine("enemy collision!!" + Health + " " + bullet.Damage);
        }

        public void calculateDirection()
        {

        }
        //public void fireGun()
        //{
        //    Bullet firedBullet = new Bullet(100f, new Vector2(Position.X, Position.Y + Texture.Height / 2), 100f, aimDirection, team);
        //    firedBullet.BulletTexture = bullet.BulletTexture;
        //    firedBullet.addCollision();
        //    firedBullets.Add(firedBullet);
        //}

        public bool isDead()
        {
            return !(health > 0);
        }
        //public void destroySelf(LivingEntity enemy, List<LivingEntity> enemies)
        //{
        //    System.Diagnostics.Debug.WriteLine("enemy collision!!");
        //    enemies.Remove(enemy);
        //    enemy = null;
        //}
    }
}
