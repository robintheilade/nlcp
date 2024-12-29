using NLCP.Entities;
using System.Collections.Generic;

namespace NLCP.Interfaces
{
    public interface ISpritesService
    {
        void AddSprite(Sprite sprite);
        void Clear();
        IEnumerable<Sprite> GetSprites();
        void RemoveSprite(Sprite sprite);
    }
}
