using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using FlockingBackend;
using System.Collections.Generic;
using System;
namespace FlockingSimulation
{

    public class RavenSprite : DrawableGameComponent
    {

        // To render
        private SpriteBatch spriteBatch;

        // Image to display
        private Texture2D ravenImage;

        // Game1 instance
        private Game1 game1;

        // Raven
        private Raven raven;

        // Default constructor
        public RavenSprite (Game1 game) : base(game)
        {
            this.game1 = game;
        }

        // Constructor Initializes game and raven
        public RavenSprite (Game1 game, Raven ravenBird) : base(game)
        {
            this.game1 = game;
            this.raven = ravenBird;
        }

        // Initialize in base class
        public override void Initialize()
        {
            base.Initialize();
        }

        // Load textures and initialize sprite batch
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            ravenImage = game1.Content.Load<Texture2D>("raven");

            base.LoadContent();
        }

        // Update in base class
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        // Draw background and  visible images when game started
        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();

            // Drawing image
            spriteBatch.Draw(ravenImage, new Microsoft.Xna.Framework.Vector2(raven.Position.Vx, raven.Position.Vy), null, Color.White, raven.Rotation, new Microsoft.Xna.Framework.Vector2(10, 10), 1, SpriteEffects.None, 0f);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}