using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Plant
    {
        string Name;
        float ActualWaterLevel;
        float Absorb;
        float MinWaterLevel;

        public Plant(string name)
        {
            Name = name;
        }

        public bool IsWaterNeeded()
        {
            return ActualWaterLevel < MinWaterLevel;
        }

        public void Water(float waterAmount)
        {
            ActualWaterLevel += waterAmount * Absorb;
        }
    }
}
