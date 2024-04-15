using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_Lesson_2_Scaling_Textures_and_Text
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D rectangleTexture;
        Texture2D circleTexture;

        Rectangle leafLeft;
        Rectangle leafRight;
        Rectangle leafMiddle;
        Rectangle tree;
        Rectangle treeHole;
        Rectangle sun;
        Rectangle dirt;
        Rectangle grass;

        SpriteFont titleFont;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();

            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 500;
            _graphics.ApplyChanges();

            sun = new Rectangle(-60, -60, 200, 200);
            dirt = new Rectangle(0, 410, 800, 90);
            grass = new Rectangle(0, 400, 800, 50);
            leafLeft = new Rectangle(520, 80, 100, 100);
            leafMiddle = new Rectangle(549, 50, 120, 120);
            leafRight = new Rectangle(600, 80, 100, 100);
            tree = new Rectangle(588, 140, 50, 260);
            treeHole = new Rectangle(593, 230, 40, 40);
            
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            circleTexture = Content.Load<Texture2D>("circle");
            rectangleTexture = Content.Load<Texture2D>("rectangle");
            titleFont = Content.Load<SpriteFont>("Title");
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

            // TODO: Add your drawing code here

            _spriteBatch.Begin();
            
            _spriteBatch.Draw(circleTexture, sun, Color.Yellow); //Sun
            _spriteBatch.Draw(rectangleTexture, dirt, Color.SaddleBrown); //Dirt
            _spriteBatch.Draw(rectangleTexture, grass, Color.LawnGreen); //Grass
            _spriteBatch.Draw(rectangleTexture, tree, Color.Brown); //Tree
            _spriteBatch.Draw(circleTexture, leafLeft, Color.ForestGreen); //Leaf left
            _spriteBatch.Draw(circleTexture, leafMiddle, Color.ForestGreen); //Leaf middle
            _spriteBatch.Draw(circleTexture, leafRight, Color.ForestGreen); //Leaf right
            _spriteBatch.Draw(circleTexture, treeHole, Color.Black); //Hole
            _spriteBatch.DrawString(titleFont, "This image took way too long to make", new Vector2(150,0), Color.Black);
            
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}