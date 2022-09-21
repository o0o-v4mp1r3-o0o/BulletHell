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
using System.Threading.Tasks;

namespace BulletHell
{
    internal class testEnemy : LivingEntity
    {
        public testEnemy(ContentManager Content)
        {
            Health = 1;
            AimDirection = 270;
            Position = new Vector2(300,50);
            Speed = 1;
            FiringRate = 3f;
            FiredBullets = new List<Bullet>();
            GameTimer = 0;
            Team = 1;
            Texture = Content.Load<Texture2D>("enemy1");
        }
        
    }
}
