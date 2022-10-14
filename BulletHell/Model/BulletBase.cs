﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BulletHell.Model
{
    internal class BulletBase : Entity, Collision
    {
        private float damage;
        private bool isOffscreen;
        private int team;

        //public Bullet(float damage, Vector2 bulletPosition, float bulletSpeed, float direction, int bulletTeam)
        //{
        //    this.Damage = damage;
        //    this.Position = bulletPosition;
        //    this.Speed = bulletSpeed;
        //    this.Direction = (float)(direction * (Math.PI / 180.0));
        //    this.Team = bulletTeam;
        //    calculateDirection();
        //}

        public float Damage { get => damage; set => damage = value; }
        public bool IsOffscreen { get => isOffscreen; set => isOffscreen = value; }
        public int Team { get => team; set => team = value; }

        public void update(int screenWidth, int screenHeight, Bullet bullet, List<Bullet> bullets)
        {
            //collision.updateBounds(bulletPosition.X, bulletPosition.Y, bulletTexture.Width, bulletTexture.Height);
            //if (bulletPosition.X > screenWidth || bulletPosition.X < bulletTexture.Width / 2 ||
            //        bulletPosition.Y > screenHeight || bulletPosition.Y < bulletTexture.Height / 2)
            //{
            //    isOffscreen = true;
            //}

        }
        public void draw(SpriteBatch _spriteBatch)
        {
            _spriteBatch.Draw(
            Texture, Position, null, Color.White, 0f, new Vector2(Texture.Width / 2, Texture.Height / 2), Vector2.One, SpriteEffects.None, 0f);
        }

        public void travelDirection(GameTime gameTime)
        {
            Vector2 curPosition = Position;
            curPosition.X += X * (float)gameTime.ElapsedGameTime.TotalSeconds;
            curPosition.Y += Y * (float)gameTime.ElapsedGameTime.TotalSeconds;
            Position = curPosition;
        }

        public void calculateDirection()
        {
            if (Direction < 90)
            {
                X = (float)Math.Cos(Direction) * Speed;
                Y = (float)Math.Sin(Direction) * Speed * -1;
            }
            else if (Direction >= 90 && Direction < 180)
            {
                X = (float)Math.Cos(180 - Direction) * Speed * -1;
                Y = (float)Math.Sin(180 - Direction) * Speed * -1;
            }
            else if (Direction >= 180 && Direction < 270)
            {
                X = (float)Math.Cos(270 - Direction) * Speed * -1;
                Y = (float)Math.Sin(270 - Direction) * Speed;
            }
            else
            {
                X = (float)Math.Cos(360 - Direction) * Speed;
                Y = (float)Math.Sin(360 - Direction) * Speed;
            }
        }

        public void destroySelf(Bullet bullet, List<Bullet> bullets)
        {
            bullets.Remove(bullet);
            bullet = null;
        }
        public bool isOnSameTeam(Bullet bullet1, Bullet bullet2)
        {
            return bullet1.BulletTeam == bullet2.BulletTeam;
        }
        //public bool isOnSameTeam(Bullet bullet, LivingEntity entity)
        //{
        //    return bullet.BulletTeam == entity.Team;
        //}
    }
}
