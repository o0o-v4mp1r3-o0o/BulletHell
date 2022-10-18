using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletHell.Model
{
    internal class BulletManager
    {
        private List<BulletBase> listOfAllBullets;


        public List<BulletBase> ListOfAllBullets { get => listOfAllBullets; set => listOfAllBullets = value; }

        public void addBullet(BulletBase bullet)
        {
            listOfAllBullets.Add(bullet);
        }

        public void removeBullet(BulletBase bullet)
        {
            listOfAllBullets.Remove(bullet);
        }



    }
}
