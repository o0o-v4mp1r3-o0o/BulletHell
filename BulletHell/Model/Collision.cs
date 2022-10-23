using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletHell.Model
{
    internal interface Collision
    {
        public bool isCollision(BulletBase bullet);
        public bool isTouchingLeft(BulletBase bullet);
        public bool isTouchingRight(BulletBase bullet);
        public bool isTouchingTop(BulletBase bullet);
        public bool isTouchingBottom(BulletBase bullet);
    }
}
