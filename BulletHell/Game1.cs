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
        YorHa yorha;
        Bullet bullet;
        List<Bullet> bullets = new List<Bullet>();

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            yorha = new YorHa(_graphics.PreferredBackBufferWidth / 2,
            _graphics.PreferredBackBufferHeight / 2,200f);
            bullet = new Bullet(100f, new Vector2(200, 200), 50f,350f);
            float c = 0;
            for(int i = 0; i < 12; i++)
            {
                bullets.Add(new Bullet(100f, new Vector2(200, 200), 50f, c));
                c += 30f;
            }
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            //bullet = Content.Load<Texture2D>("bulletreal");
            yorha.YorhaTexture = Content.Load<Texture2D>("YorHa");
            bullet.BulletTexture = Content.Load<Texture2D>("bulletreal");
            foreach (Bullet bullet in bullets)
            {
                bullet.BulletTexture = Content.Load<Texture2D>("bulletreal");
            }
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            yorha.input(gameTime, _graphics.PreferredBackBufferWidth, _graphics.PreferredBackBufferHeight);
            bullet.travelDirection(gameTime);
            foreach (Bullet bullet in bullets)
            {
                bullet.travelDirection(gameTime);
            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            yorha.draw(_spriteBatch);
            bullet.draw(_spriteBatch);
            foreach (Bullet bullet in bullets)
            {
                bullet.draw(_spriteBatch);
            }
            _spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}