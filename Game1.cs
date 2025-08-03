using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using DungeonSlime.MonoGameLibrary;

namespace DungeonSlime;

public class Game1 : Core
{
    private Texture2D _logo;
    public Game1() : base("Dungeon Slime", 1280, 720, false)
    { }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here
        base.Initialize();
    }

    protected override void LoadContent()
    {
        // TODO: use this.Content to load your game content here
        _logo = Content.Load<Texture2D>("images/logo");

        // base.LoadContent();
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
        GraphicsDevice.Clear(Color.DarkBlue);
        // TODO: Add your drawing code here

        SpriteBatch.Begin();
        SpriteBatch.Draw(
            _logo, // texture
            new Vector2(
                Window.ClientBounds.Width, Window.ClientBounds.Height
            ) * 0.5f, // position
            null, // source rectangle
            Color.White, // color
            0.0f, // rotation
            new Vector2(
                _logo.Width, _logo.Height
            ) * 0.5f, // origin
            new Vector2(1.5f, 0.5f), // scale
            SpriteEffects.FlipHorizontally |
            SpriteEffects.FlipVertically , // effects
            0.0f // layer depth
        );
        SpriteBatch.End();

        base.Draw(gameTime);
    }
}
