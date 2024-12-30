using Microsoft.Xna.Framework.Graphics;

namespace NLCP.Services
{
    public class SpriteBatchService
    {
        private readonly SpriteBatch _spriteBatch;

        public SpriteBatchService(SpriteBatch spriteBatch)
        {
            _spriteBatch = spriteBatch;
        }

        public SpriteBatch SpriteBatch => _spriteBatch;
    }
}
