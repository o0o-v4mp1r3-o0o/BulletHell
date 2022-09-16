using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletHell
{
    internal class LivingEntity
    {
        protected float health;
        protected float damage;
        protected Bullet bullet;
        protected float shootingRate;
        protected string name;
        protected int id;
        protected Texture2D texture;
        protected Vector2 position;
        protected float speed;
        protected Collision collision;
        protected float aimDirection;
    }
}
