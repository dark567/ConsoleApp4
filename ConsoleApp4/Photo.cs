using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    
    public class Photo
    {
        [Geo(10, 20)]
        public string Name { get; set; }
        public string Path { get; set; }

        public Photo(string name)
        {
            if (string.IsNullOrEmpty(name))
                this.Name = name;
        }

    }
}
