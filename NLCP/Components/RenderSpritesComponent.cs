using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
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
            var spriteBatch = this._spriteBatchService.SpriteBatch;
            spriteBatch.Begin(samplerState: SamplerState.PointClamp);
            foreach (var sprite in _spriteService.GetSprites())
            {
                spriteBatch.Draw(
                    sprite.Texture,
                    sprite.Position,
                    sprite.SourceRectangle,
                    sprite.Color,
                    sprite.Rotation,
                    sprite.Origin,
                    sprite.Scale,
                    sprite.Effects,
                    sprite.LayerDepth
                    );
            }
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
