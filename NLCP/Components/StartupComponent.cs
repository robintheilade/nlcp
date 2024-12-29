using Microsoft.Xna.Framework;
using NLCP.Interfaces;
using NLCP.Services;

namespace NLCP.Components
{
    internal class StartupComponent : GameComponent
    {
        public StartupComponent(Game game) : base(game)
        {
        }

        public override void Initialize()
        {
            var clearScreenComponent = new ClearScreenComponent(Game);

            Game.Components.Add(clearScreenComponent);

            Game.Services.AddService<ISpritesService>(new SpritesService());
        }
    }
}
