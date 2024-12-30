using NLCP.Entities;
using NLCP.Interfaces;
using System.Collections.Generic;

namespace NLCP.Services
{
    public class SpritesService : ISpritesService
    {
        private readonly List<Sprite> _sprites;

        public IEnumerable<Sprite> GetSprites() => _sprites;

        public void AddSprite(Sprite sprite)
        {
            _sprites.Add(sprite);
        }

        public void RemoveSprite(Sprite sprite)
        {
            _sprites.Remove(sprite);
        }

        public void Clear()
        {
            _sprites.Clear();
        }
    }
}
