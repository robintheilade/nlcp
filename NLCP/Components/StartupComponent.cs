using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
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

            Game.Services.AddService(new SpriteBatchService(new SpriteBatch(Game.GraphicsDevice))); // this must be before the components, as the components might try to get an instance of spritebatch
            Game.Services.AddService<ISpritesService>(new SpritesService());

            Game.Components.Add(clearScreenComponent);
            this.Game.Components.Add(new PersonComponent(this.Game));
            this.Game.Components.Add(new RenderSpritesComponent(this.Game));
        }
    }
}
