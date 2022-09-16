using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletHell
{
    internal class Input
    {
        private bool isGame;
        private bool isMenu;
        private bool isTitleScreen;

        public bool IsGame { get => isGame; set => isGame = value; }
        public bool IsMenu { get => isMenu; set => isMenu = value; }
        public bool IsTitleScreen { get => isTitleScreen; set => isTitleScreen = value; }

        public void inputState(GameTime gameTime, int screenWidth, int screenHeight, Vector2 yorhaPosition, float yorhaSpeed)
        {
            if (isGame)
            {
                gameMovements(gameTime, screenWidth, screenHeight, yorhaPosition,yorhaSpeed);
            }
            else if (isMenu)
            {
                menuMovements();
            }
            else if (isTitleScreen)
            {
                titleMovements();
            }
        }

        public void gameMovements(GameTime gameTime, int screenWidth, int screenHeight, Vector2 yorhaPosition, float yorhaSpeed)
        {
            var kstate = Keyboard.GetState();
            if (kstate.IsKeyDown(Keys.Up))
            {
                yorhaPosition.Y -= yorhaSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }

            if (kstate.IsKeyDown(Keys.Down))
            {
                yorhaPosition.Y += yorhaSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }

            if (kstate.IsKeyDown(Keys.Left))
            {
                yorhaPosition.X -= yorhaSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }

            if (kstate.IsKeyDown(Keys.Right))
            {
                yorhaPosition.X += yorhaSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }

        }

        public void menuMovements()
        {
            var kstate = Keyboard.GetState();
        }

        public void titleMovements()
        {
            var kstate = Keyboard.GetState();
        }
    }
}
