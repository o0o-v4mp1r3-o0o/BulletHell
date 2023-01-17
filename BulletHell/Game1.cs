using BulletHell.Controller;
using BulletHell.Model;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Net.Mime;

namespace BulletHell
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Input input = new Input();
        YorHa yorha;
        List<BulletA> bulletAList = new List<BulletA>();
        List<LivingEntity> enemies = new List<LivingEntity>();
        private BulletFactory bulletFactory;
        private BulletManager bulletManager;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            bulletFactory = BulletFactory.GetBulletFactory();
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            System.Diagnostics.Debug.WriteLine("hi!");
            input.IsGame = true;
            yorha = new YorHa(_graphics.PreferredBackBufferWidth / 2,
            _graphics.PreferredBackBufferHeight / 2, 200f);

            LoadContent();

            bulletManager = BulletManager.GetBulletManager();
            bulletManager.loadBulletTextures(Content);
            float c = 0;
            for (int i = 0; i < 12; i++)
            {
                BulletA tempBullet = (BulletA)bulletFactory.buildBullet(BulletFactory.BulletType.BulletA);
                tempBullet.Texture = bulletManager.BulletA;
                tempBullet.Position = new Vector2(200, 200);
                tempBullet.Direction = c;
                c += 30f;
                tempBullet.Speed = 50f;
                tempBullet.Team = 1;
                tempBullet.setBoundsWidthHeight();
                bulletManager.addBullet(tempBullet);
                //bulletAList.Add(tempBullet);
            }

            //float c = 0;
            //for(int i = 0; i < 12; i++)
            //{
            //    bullets.Add(new Bullet(100f, new Vector2(200, 200), 50f, c,1));
            //    c += 30f;
            //}
            yorha.setBoundsWidthHeight();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            yorha.Texture = Content.Load<Texture2D>("YorHa");
            //bulletManager.loadBulletTextures(Content);
            //yorha.addFeatures(Content);
            //foreach (testEnemy testEnemy in enemies)
            //{
            //    testEnemy.addFeatures(Content);
            //}
            //foreach (Bullet bullet in bullets)
            //{
            //    bullet.BulletTexture = Content.Load<Texture2D>("bulletreal");
            //    bullet.addCollision();
            //}
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            //yorha.input(gameTime, _graphics.PreferredBackBufferWidth, _graphics.PreferredBackBufferHeight, Content);
            input.inputState(gameTime, _graphics.PreferredBackBufferWidth, _graphics.PreferredBackBufferHeight, yorha);
            yorha.update();

            bulletManager.updateBulletPositions(gameTime);
            bulletManager.checkYorhaCollision(yorha);

            //foreach (BulletBase bullet in deadList)
            //{
            //    bulletAList.Remove((BulletA)bullet);
            //}

            //deadList.Clear();

            //foreach(LivingEntity l in enemies)
            //{
            //    l.update(gameTime, _graphics.PreferredBackBufferWidth, _graphics.PreferredBackBufferHeight);
            //}

            //for(int i = 0; i < bullets.Count; i++)
            //{
            //    bullets[i].travelDirection(gameTime);
            //    bullets[i].update(_graphics.PreferredBackBufferWidth, _graphics.PreferredBackBufferHeight, bullets[i],bullets);
            //    if (bullets[i].IsOffscreen)
            //    {
            //        bullets[i].destroySelf(bullets[i], bullets);
            //        i--;
            //    }
            //    else if (yorha.Collision.isCollision(bullets[i], bullets))
            //    {
            //        yorha.takeDamage(bullets[i]);
            //        System.Diagnostics.Debug.WriteLine(yorha.YorhaHealth);
            //        bullets[i].destroySelf(bullets[i], bullets);
            //        i--;
            //    }
            //}


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            yorha.draw(_spriteBatch);
            bulletManager.drawbullets(_spriteBatch);
            //foreach (LivingEntity l in enemies)
            //{
            //    l.draw(_spriteBatch);
            //}
            _spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}