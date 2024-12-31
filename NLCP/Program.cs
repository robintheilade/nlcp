using Microsoft.Xna.Framework;
using NLCP.Components;
using NLCP.Constants;

var game = new Game();

// GraphicsDeviceManager constructor will assign itself to the game, we do not need to store the instance in a variable
new GraphicsDeviceManager(game)
{
    PreferredBackBufferWidth = Resolution.Width,
    PreferredBackBufferHeight = Resolution.Height,
};

game.Content.RootDirectory = "Content";
game.IsMouseVisible = true;

game.Components.Add(new StartupComponent(game));

game.Run();