using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletHell.Model
{
    internal class GameObject
    {
        private Vector2 position;

        public Vector2 Position { get => position; set => position = value; }
    }
}
