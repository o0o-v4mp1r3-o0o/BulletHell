using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletHell.Model
{
    internal class PlayerBase : LivingEntity, Collision
    {
        private bool isPlayer = true;
    }
}
