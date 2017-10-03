using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Tree : Plant
    {
        public Tree(string name) : base(name)
        {
            Absorb = 0.4f;
            MinWaterLevel = 10;
            PlantType = "tree";
        }
    }
}
