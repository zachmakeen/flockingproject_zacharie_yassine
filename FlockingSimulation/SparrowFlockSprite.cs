using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using FlockingBackend;
using System.Collections.Generic;
using System;
namespace FlockingSimulation
{
    
    public class SparrowFlockSprite : DrawableGameComponent
    {
        
        // To render
        private SpriteBatch spriteBatch;
        
        // Image to display
        private Texture2D sparrowImage;

        // Game1 instance
        private Game1 game1;

        

        // List of sparrows
        private  List<Sparrow> sparrows;

        // Default constructor
        public SparrowFlockSprite (Game1 game) : base(game)
        {
            this.game1 = game;
        }

        // Constructor Initializes game and sparrows list
        public SparrowFlockSprite (Game1 game, List<Sparrow> sparrowBirds) : base(game)
        {
            this.game1 = game;
            sparrows = sparrowBirds;
            
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
            sparrowImage = game1.Content.Load<Texture2D>("sparrow");
            
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
            
            // Drawing visible Images
            foreach( Sparrow sparrow in sparrows )
            {

                spriteBatch.Draw(sparrowImage, new Microsoft.Xna.Framework.Vector2(sparrow.Position.Vx, sparrow.Position.Vy), null, Color.White, sparrow.Rotation, new Microsoft.Xna.Framework.Vector2(10, 10), 1, SpriteEffects.None, 0f);
            }
        
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}    