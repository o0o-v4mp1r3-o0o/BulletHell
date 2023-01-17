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
        private List<BulletBase> listOfEnemyBullets;
        private List<BulletBase> listOfDeadBullets;
        public Texture2D BulletA;
        public Texture2D BulletB;


        private static BulletManager instance;
        public List<BulletBase> ListOfAllBullets { get => listOfAllBullets; set => listOfAllBullets = value; }
        public List<BulletBase> ListOfEnemyBullets { get => listOfAllBullets; set => listOfAllBullets = value; }
        public List<BulletBase> ListOfDeadBullets { get => listOfAllBullets; set => listOfAllBullets = value; }

        private BulletManager()
        {
            listOfAllBullets = new List<BulletBase>();
            listOfEnemyBullets = new List<BulletBase>();
            listOfDeadBullets = new List<BulletBase>();
        }

        public static BulletManager GetBulletManager()
        {
            if (instance == null)
            {
                instance = new BulletManager();
            }
            return instance;
        }

        public void checkYorhaCollision(YorHa yorha)
        {
            foreach (BulletBase b in listOfEnemyBullets)
            {
                if (yorha.isCollision(b))
                {
                    yorha.takeDamage(b);
                    listOfDeadBullets.Add(b);
                }
            }
        }


        public void addBullet(BulletBase bullet)
        {
            listOfAllBullets.Add(bullet);
            if (bullet.Team != 0)
            {
                listOfEnemyBullets.Add(bullet);
            }
        }

        public void clearBullets()
        {
            listOfAllBullets.Clear();
        }
        public void clearEnemyBullets()
        {
            listOfEnemyBullets.Clear();
        }

        public void checkDeadBullets()
        {
            foreach (BulletBase b in listOfDeadBullets)
            {
                if (b.Team != 0)
                {
                    ListOfEnemyBullets.Remove(b);
                }
                ListOfAllBullets.Remove(b);
            }
        }

        public void updateBulletPositions(GameTime gameTime)
        {
            checkDeadBullets();
            foreach (BulletBase bullet in ListOfAllBullets)
            {
                bullet.update(gameTime);
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
