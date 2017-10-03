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
        protected string PlantType;
        float ActualWaterLevel;
        protected float Absorb;
        protected float MinWaterLevel;

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

        public void GetStatus()
        {
            string status = "doesn't need water";
            if (IsWaterNeeded())
            {
                status = "needs water";
            }
            Console.WriteLine("The {0} {1} {2}.", Name, PlantType, status);
        }
    }
}
