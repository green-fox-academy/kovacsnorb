using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Flower : Plant
    {
        public Flower(string name) : base(name)
        {
            Absorb = 0.75f;
            MinWaterLevel = 5;
            PlantType = "flower";
        }
    }
}
