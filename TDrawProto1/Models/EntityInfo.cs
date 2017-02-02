using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDrawProto1.Models
{
    public class EntityInfo
    {
        public string Name { get; set; }

        public string Left { get; set; }
        public string Right { get; set; }

        public string EntityType { get; set; }
        public float X { get; set; }
        public float Y { get; set; }

        public float Width { get; set; }
        public float Height { get; set; }
    }
}
