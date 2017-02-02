using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDrawProto1.Utils
{
    public class Transform2D
    {
        public float OffsetX { get; set; } = 0F;
        public float OffsetY { get; set; } = 0F;

        public float Scale { get; set; } = 1.0F;

        public PointF WorldToLocal(float x, float y)
        {
            return WorldToLocal(new PointF(x, y));
        }
        public PointF WorldToLocal(PointF world)
        {
            return new PointF(world.X * Scale, world.Y * Scale);
        }
        public PointF LocalToWorld(float x, float y)
        {
            return LocalToWorld(new PointF(x, y));
        }
        public PointF LocalToWorld(PointF world)
        {
            return new PointF(world.X / Scale, world.Y / Scale);
        }
    }
}
