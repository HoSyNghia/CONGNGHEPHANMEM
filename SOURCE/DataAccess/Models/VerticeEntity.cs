using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public abstract class VerticeEntity
    {
        public Color Color { get; set; }
        public List<Color> ColorsUsed = new List<Color>();
        public List<VerticeEntity> VerticesRelated = new List<VerticeEntity>();
    }
}
