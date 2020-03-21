using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class GeoAttribute:Attribute
    {
        public int X { get; set; }
        public int Y { get; set; }

        public GeoAttribute()
        {

        }

        public GeoAttribute(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
