using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace BulletHell.Model
{
    internal class Entity : GameObject
    {
        private Texture2D texture;
        private Vector2 position;
        private float speed;
        private float direction;
        private float distance;
        private float x, y;

        public Texture2D Texture { get => texture; set => texture = value; }
        public Vector2 Position { get => position; set => position = value; }
        public float Speed { get => speed; set => speed = value; }
        public float Direction { get => direction; set => direction = value; }
        public float Distance { get => distance; set => distance = value; }
        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }
    }
}
