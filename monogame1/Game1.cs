using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace monogame1
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D dinoDestroy, building, beam, choppa, background;

        public int x, y;
        Random generator = new Random();


       

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;


        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 800;
            _graphics.ApplyChanges();

            x = generator.Next(20, 600);
            y = generator.Next(20, 600);


            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            if (x <= 310)
            {
                background = Content.Load<Texture2D>("cityBurn");
            }
            else
            {
                background = Content.Load<Texture2D>("burnCity");
            }

            dinoDestroy = Content.Load<Texture2D>("dino");
            building = Content.Load<Texture2D>("building");
            choppa = Content.Load<Texture2D>("choppa");
            beam = Content.Load<Texture2D>("red beam");


            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {


            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            _spriteBatch.Draw(background, new Vector2(0,0), Color.White);
            _spriteBatch.Draw(dinoDestroy, new Vector2(1, 500), Color.White );
            _spriteBatch.Draw(building, new Vector2(500, 1), Color.White);
            _spriteBatch.Draw(beam, new Vector2(120, 563), Color.White);
            _spriteBatch.Draw(choppa, new Vector2(x, y), Color.White);



            _spriteBatch.End();


            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}