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
        private float damage;
        private float firingRate;
        private float aimDirection;
        private int team;

        public float Health { get => health; set => health = value; }
        public float Damage { get => damage; set => damage = value; }
        public float FiringRate { get => firingRate; set => firingRate = value; }
        public float AimDirection { get => aimDirection; set => aimDirection = value; }
        public int Team { get => team; set => team = value; }

        public void update(GameTime gameTime, int screenWidth, int screenHeight)
        {
            //collision.updateBounds(Position.X, Position.Y, Texture.Width, Texture.Height);
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

        public void movement()
        {

        }
        public void takeDamage(Bullet bullet, LivingEntity enemy, List<LivingEntity> enemies)
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
