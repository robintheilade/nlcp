using Microsoft.Xna.Framework;
using NLCP.Interfaces;
using NLCP.Services;

namespace NLCP.Components
{
    public class RenderSpritesComponent : DrawableGameComponent
    {
        private readonly ISpritesService _spriteService;

        private readonly SpriteBatchService _spriteBatchService;

        public RenderSpritesComponent(Game game) : base(game)
        {
            _spriteService = game.Services.GetService<ISpritesService>();

            _spriteBatchService = game.Services.GetService<SpriteBatchService>();
        }

        public override void Draw(GameTime gameTime)
        {
            foreach (var sprite in _spriteService.GetSprites())
            {
                //TODO: Draw Sprites
            }

            base.Draw(gameTime);
        }
    }
}
