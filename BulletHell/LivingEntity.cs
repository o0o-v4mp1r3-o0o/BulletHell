using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BulletHell
{
    internal class LivingEntity
    {
        private Texture2D texture;
        private Vector2 position;
        private float speed;
        private float distance;
        private float health;
        private Collision collision;
        private Bullet bullet;
        private List<Bullet> firedBullets;
        private float damage;
        private float firingRate;
        private float gameTimer;
        private float aimDirection;
        private int team;

        public Texture2D Texture { get => texture; set => texture = value; }
        public Vector2 Position { get => position; set => position = value; }
        public float Speed { get => speed; set => speed = value; }
        public float Distance { get => distance; set => distance = value; }
        public float Health { get => health; set => health = value; }
        public float Damage { get => damage; set => damage = value; }
        public float FiringRate { get => firingRate; set => firingRate = value; }
        public float GameTimer { get => gameTimer; set => gameTimer = value; }
        public float AimDirection { get => aimDirection; set => aimDirection = value; }
        public int Team { get => team; set => team = value; }
        public Collision Collision { get => collision; set => collision = value; }
        public Bullet Bullet { get => bullet; set => bullet = value; }
        public List<Bullet> FiredBullets { get => firedBullets; set => firedBullets = value; }

        public void addFeatures(ContentManager Content)
        {
            collision = new Collision(Position.X, Position.Y, Texture.Width, Texture.Height);
            bullet = new Bullet(100f, new Vector2(Position.X, Position.Y - Texture.Height / 2), 1000f, aimDirection, 0);
            bullet.BulletTexture = Content.Load<Texture2D>("bulletreal");

        }
        public void update(GameTime gameTime, int screenWidth, int screenHeight)
        {
            collision.updateBounds(Position.X, Position.Y, Texture.Width, Texture.Height);
            for (int i = 0; i < firedBullets.Count; i++)
            {
                firedBullets[i].travelDirection(gameTime);
                firedBullets[i].update(screenWidth, screenHeight, firedBullets[i], firedBullets);
                if (firedBullets[i].IsOffscreen)
                {
                    firedBullets[i].destroySelf(firedBullets[i], firedBullets);
                    i--;
                }
            }

            if ((float)gameTime.TotalGameTime.TotalSeconds - gameTimer > FiringRate)
            {
                gameTimer = (float)gameTime.TotalGameTime.TotalSeconds;
                fireGun();
            }

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

            foreach (Bullet bullet in firedBullets)
            {
                _spriteBatch.Draw(
            bullet.BulletTexture, bullet.BulletPosition, null, Color.White, 0f, new Vector2(bullet.BulletTexture.Width / 2, bullet.BulletTexture.Height / 2), Vector2.One, SpriteEffects.None, 0f);
            }
        }

        public void movement()
        {

        }
        public void takeDamage(Bullet bullet, LivingEntity enemy, List<LivingEntity> enemies)
        {
            Health -= bullet.Damage;
            System.Diagnostics.Debug.WriteLine("enemy collision!!" + Health + " " + bullet.Damage);
            if (isDead()) destroySelf(enemy, enemies);
        }

        public void calculateDirection()
        {

        }
        public void fireGun()
        {
            Bullet firedBullet = new Bullet(100f, new Vector2(Position.X, Position.Y + Texture.Height / 2), 100f, aimDirection, team);
            firedBullet.BulletTexture = bullet.BulletTexture;
            firedBullet.addCollision();
            firedBullets.Add(firedBullet);
        }

        public bool isDead()
        {
            return !(health > 0);
        }
        public void destroySelf(LivingEntity enemy, List<LivingEntity> enemies)
        {
            System.Diagnostics.Debug.WriteLine("enemy collision!!");
            enemies.Remove(enemy);
            enemy = null;   
        }
    }
}
