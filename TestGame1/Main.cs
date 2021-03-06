﻿#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
#endregion

namespace TestGame1
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Main : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        #region Ablak paraméterek
        public static int WIDTH = 4, HEIGHT = 3, SCALE = 160, w = WIDTH * SCALE, h = HEIGHT * SCALE;
        public static string TITLE = "TITLE WOW SUCH GAME";
        #endregion

        // Játék osztály, ott lesz a fő logika, MAIN-T HAGYNI!!!
        GameClass game;

        #region Teszt cuccok ide!
        #endregion

        public Main()
            : base()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            SetWindowPrefferences();

            Resources.setContentLoader(Content);

            base.Initialize();
        }

        protected void SetWindowPrefferences()
        {
            
            graphics.PreferredBackBufferWidth = w;
            graphics.PreferredBackBufferHeight = h;

            Window.Title = TITLE;

        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);



            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            game.input();

            game.tick();

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(new Color(0.5f, 0.5f, 0.5f, 0.5f));

            // spriteBatch Begin End közé rajzolás, Camera translate előtt a Parallax cuccok,
            // Utána a GUI cuccok

            spriteBatch.Begin();

            game.render();

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
