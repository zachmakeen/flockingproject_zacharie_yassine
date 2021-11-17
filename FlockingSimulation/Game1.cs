using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using FlockingBackend;
namespace FlockingSimulation
{
    public class Game1 : Game
    {
        // Graphics
        private GraphicsDeviceManager _graphics;
        
        // Sprite batch
        private SpriteBatch _spriteBatch;

        // Access to the backend world
        private World world;

        // Sprite class to draw sparrows
        private SparrowFlockSprite sparrowFlockSprite;

        // Sprite class to draw raven
        private RavenSprite ravenSprite;

        // Constructor initialiaze the game world.
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            world = new World();
        }

        // Initialize fields
        protected override void Initialize()
        {
    
            // Set Screen width and height
            _graphics.PreferredBackBufferHeight = World.Height;
            _graphics.PreferredBackBufferWidth = World.Width;

            // Cretae Sparrow sprite
            sparrowFlockSprite = new SparrowFlockSprite(this, world.Sparrows);
            
            // Add it to component
            Components.Add(sparrowFlockSprite);

            // Cretae Raven sprite
            ravenSprite = new RavenSprite(this, world.RavenBird);

             // Add it to component
            Components.Add(ravenSprite);

            _graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

        }

        // Update every tick
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // Update the birds world 
            world.Update();
            
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // Darawing in sprite classes
            base.Draw(gameTime);
        }
    }
}