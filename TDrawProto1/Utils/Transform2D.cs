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

        PointF WorldToLocal(PointF world)
        {
            return new PointF(world.X * Scale, world.Y * Scale);
        }
        PointF LocalToWorld(PointF world)
        {
            return new PointF(world.X / Scale, world.Y / Scale);
        }
    }
}
