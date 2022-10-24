using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
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
        public Texture2D BulletA;
        public Texture2D BulletB;


        public List<BulletBase> ListOfAllBullets { get => listOfAllBullets; set => listOfAllBullets = value; }

        public void addBullet(BulletBase bullet)
        {
            listOfAllBullets.Add(bullet);
        }

        public void removeBullet(BulletBase bullet)
        {
            listOfAllBullets.Remove(bullet);
        }

        public void clearBullets()
        {
            listOfAllBullets.Clear();
        }

        public void updateBulletPositions(GameTime gameTime, List<BulletBase> deadList, YorHa yorha)
        {

            foreach (BulletBase bullet in ListOfAllBullets)
            {
                bullet.update(gameTime);
                if (yorha.isCollision(bullet))
                {
                    deadList.Add(bullet);
                }
            }
        }

        public void drawbullets(SpriteBatch spriteBatch)
        {
            foreach (BulletBase bullet in ListOfAllBullets)
            {
                bullet.draw(spriteBatch);
            }
        }

        public void loadBulletTextures(ContentManager content)
        {
            BulletA = content.Load<Texture2D>("bulletreal");
            BulletB = content.Load<Texture2D>("YorHaBullet");
        }



    }
}
