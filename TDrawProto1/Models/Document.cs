using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDrawProto1.Utils;

namespace TDrawProto1.Models
{
    public class Document
    {
        public List<EntityInfo> Entities { get; private set; } = new List<EntityInfo>();

        public Transform2D Transform { get; set; } = new Transform2D();
    }
}
