using Microsoft.Xna.Framework;
using NLCP.Interfaces;

namespace NLCP.Components
{
    public class RenderSpritesComponent : DrawableGameComponent
    {
        private readonly ISpritesService _spriteService;

        public RenderSpritesComponent(Game game) : base(game)
        {
            _spriteService = game.Services.GetService<ISpritesService>();
        }

        public override void Draw(GameTime gameTime)
        {
            foreach (var sprite in _spriteService.GetSprites())
            {

            }

            base.Draw(gameTime);
        }
    }
}
