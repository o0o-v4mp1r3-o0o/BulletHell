using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletHell.Model
{
    internal class EnemyBase : LivingEntity, Collision
    {
        private float damage;
        private bool isOffscreen;
        private int bulletTeam;

        
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
    }
}
