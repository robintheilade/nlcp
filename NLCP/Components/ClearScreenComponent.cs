using Microsoft.Xna.Framework;

namespace NLCP.Components
{
    public class ClearScreenComponent : DrawableGameComponent
    {
        public ClearScreenComponent(Game game) : base(game)
        {
        }

        public override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            base.Draw(gameTime);
        }
    }
}
