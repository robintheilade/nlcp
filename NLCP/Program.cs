using Microsoft.Xna.Framework;
using NLCP.Components;

var game = new Game();

// GraphicsDeviceManager constructor will assign itself to the game, we do not need to store the instance in a variable
new GraphicsDeviceManager(game);

game.Content.RootDirectory = "Content";
game.IsMouseVisible = true;

var clearScreenComponent = new ClearScreenComponent(game);

game.Components.Add(clearScreenComponent);

game.Run();