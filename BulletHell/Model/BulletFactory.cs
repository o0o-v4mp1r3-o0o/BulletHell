using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletHell.Model
{
    internal class BulletFactory
    {
        protected internal enum BulletType
        {
            BulletA,
            BulletB
        }

        private static BulletFactory instance = null;

        private BulletFactory()
        {
            
        }

        public static BulletFactory GetBulletFactory()
        {
            if (instance == null)
            {
                instance = new BulletFactory();
            }
            return instance;
        }

        public BulletBase buildBullet(BulletType bulletType)
        {
            switch(bulletType)
            {
                case BulletType.BulletA: return new BulletA();
                case BulletType.BulletB: return new BulletB();
            }

            return null;
        }
    }
}
