using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Reflection.Metadata;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace BulletHell.Model
{
    internal class YorHa : PlayerBase
    {
        public YorHa(int YLocation, int XLocation, float speed)
        {
            Health = 100;
            Speed = speed;
            FiringRate = .1f;
            Team = 0;
            X = XLocation;
            Y = YLocation;
        }
        //public void addFeatures(ContentManager Content)
        //{
        //    collision = new Collision(yorhaPosition.X, yorhaPosition.Y, yorhaTexture.Width, yorhaTexture.Height);
        //    bullet = new Bullet(100f, new Vector2(yorhaPosition.X, yorhaPosition.Y - yorhaTexture.Height / 2), 1000f, 90f, 0);
        //    bullet.BulletTexture = Content.Load<Texture2D>("YorHaBullet");
        //}

        //public void input(GameTime gameTime, int screenWidth, int screenHeight, ContentManager Content)
        //{
        //    var kstate = Keyboard.GetState();
        //    var mstate = Mouse.GetState();

        //    if (mstate.LeftButton == ButtonState.Pressed)
        //    {
        //        if ((float)gameTime.TotalGameTime.TotalSeconds - gameTimer > yorhaFiringRate)
        //        {
        //            gameTimer = (float)gameTime.TotalGameTime.TotalSeconds;
        //            fireGun(Content);
        //        }
        //    }
        //    if (yorhaPosition.X > screenWidth - yorhaTexture.Width / 2)
        //    {
        //        yorhaPosition.X = screenWidth - yorhaTexture.Width / 2;
        //    }
        //    else if (yorhaPosition.X < yorhaTexture.Width / 2)
        //    {
        //        yorhaPosition.X = yorhaTexture.Width / 2;
        //    }

        //    if (yorhaPosition.Y > screenHeight - yorhaTexture.Height / 2)
        //    {
        //        yorhaPosition.Y = screenHeight - yorhaTexture.Height / 2;
        //    }
        //    else if (yorhaPosition.Y < yorhaTexture.Height / 2)
        //    {
        //        yorhaPosition.Y = yorhaTexture.Height / 2;
        //    }
        //}

        public void update(GameTime gameTime, int screenWidth, int screenHeight, List<BulletA> bullets, List<LivingEntity> enemies)
        {
            //collision.updateBounds(yorhaPosition.X, yorhaPosition.Y, yorhaTexture.Width, yorhaTexture.Height);
            //for(int i = 0; i < firedBullets.Count; i++)
            //{
            //    //firedBullets[i].travelDirection(gameTime);
            //    //firedBullets[i].update(screenWidth, screenHeight, firedBullets[i],firedBullets);
            //    //if (firedBullets[i].IsOffscreen)
            //    //{
            //    //    firedBullets[i].destroySelf(firedBullets[i], firedBullets);
            //    //    i--;
            //    //}
            //    //foreach (Bullet bullet in bullets)
            //    //{
            //    //    if (i < 0) break;
            //    //    if (firedBullets[i].Collision.isCollision(bullet, bullets) && !bullet.isOnSameTeam(firedBullets[i],bullet))
            //    //    {
            //    //        bullet.destroySelf(bullet, bullets);
            //    //        firedBullets[i].destroySelf(firedBullets[i], firedBullets);
            //    //        i--;
            //    //        break;
            //    //    }
            //    //}
            //    //if (i < 0) break;
            //    //foreach (LivingEntity enemy in enemies)
            //    //{
            //    //    if (i < 0) break;
            //    //    if (enemy.Collision.isCollision(firedBullets[i], firedBullets) && !firedBullets[i].isOnSameTeam(firedBullets[i], enemy))
            //    //    {

            //    //        enemy.takeDamage(firedBullets[i], enemy, enemies);
            //    //        firedBullets[i].destroySelf(firedBullets[i], firedBullets);
            //    //        i--;
            //    //        break;
            //    //    }
            //    //}
            //    //if (i < 0) break;
            //}

        }
        //public void draw(SpriteBatch _spriteBatch)
        //{
        //    _spriteBatch.Draw(
        //    Texture,
        //    Position,
        //    null,
        //    Color.White,
        //    0f,
        //    new Vector2(Texture.Width / 2, Texture.Height / 2),
        //    Vector2.One,
        //    SpriteEffects.None,
        //    0f);
        //    //foreach (Bullet bullet in firedBullets)
        //    //{
        //    //    _spriteBatch.Draw(
        //    //bullet.BulletTexture, bullet.BulletPosition, null, Color.White, 0f, new Vector2(bullet.BulletTexture.Width / 2, bullet.BulletTexture.Height / 2), Vector2.One, SpriteEffects.None, 0f);
        //    //}
        //}
        public void takeDamage(BulletA bullet)
        {
            Health -= bullet.Damage;
        }

        //public void calculateDirection()
        //{

        //}
        //public void fireGun(ContentManager Content)
        //{
        //    Bullet firedBullet = new Bullet(100f, new Vector2(yorhaPosition.X, yorhaPosition.Y - yorhaTexture.Height / 2), 1000f, aimDirection, team);
        //    firedBullet.BulletTexture = bullet.BulletTexture;
        //    firedBullet.addCollision();
        //    firedBullets.Add(firedBullet);
        //}
    }
}
