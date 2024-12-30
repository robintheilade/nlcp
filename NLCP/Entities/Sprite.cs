using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace NLCP.Entities
{
    public class Sprite
    {
        public Texture2D Texture { get; set; }
        public Vector2 Position { get; set; }
        public Rectangle? SourceRectangle { get; set; }
        public Color Color { get; set; } = Color.White;
        public float Rotation { get; set; }
        public Vector2 Origin { get; set; }
        public Vector2 Scale { get; set; } = Vector2.One;
        public SpriteEffects Effects { get; set; }
        public float LayerDepth { get; set; } = 0.5f;
    }
}
