using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NLCP.Constants;
using NLCP.Entities;
using NLCP.Interfaces;

namespace NLCP.Components
{
    // for now we can have this class but we might want to split it into locomotion, user input response and so on
    public class PersonComponent : DrawableGameComponent
    {
        private Sprite _sprite;

        public PersonComponent(Game game) : base(game)
        {
        }

        protected override void LoadContent()
        {
            base.LoadContent();

            var assetName = $"textures/people/{PeopleTextureNames.Placeholder}/{PersonTextureNames.MovementHorizontal}0"; // load frame zero of the horizontal movement
            var texture = this.Game.Content.Load<Texture2D>(assetName);
            this._sprite = new Sprite()
            {
                Position = new Vector2(650, 610),
                Texture = texture,
            };

            var sprites = this.Game.Services.GetService<ISpritesService>();
            sprites.AddSprite(this._sprite);
        }
    }
}
