using Microsoft.Xna.Framework;
using NLCP.Components;

var game = new Game();

// GraphicsDeviceManager constructor will assign itself to the game, we do not need to store the instance in a variable
new GraphicsDeviceManager(game);

game.Content.RootDirectory = "Content";
game.IsMouseVisible = true;

game.Components.Add(new StartupComponent(game));

game.Run();