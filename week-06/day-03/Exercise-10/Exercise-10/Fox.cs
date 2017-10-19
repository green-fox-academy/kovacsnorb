using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
{
    public class Fox
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Colour { get; set; }

        public Fox(string name, string type, string colour)
        {
            this.Name = name;
            this.Type = type;
            this.Colour = colour;
        }


    }
}
