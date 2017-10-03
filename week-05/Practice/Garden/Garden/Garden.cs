using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Garden
    {
        List<Plant> plants;

        public Garden()
        {
            plants = new List<Plant>();
            plants.Add(new Flower("yellow"));
            plants.Add(new Flower("blue"));
            plants.Add(new Tree("purple"));
            plants.Add(new Tree("orange"));
            PrintStatus();
        }

        public void PrintStatus()
        {
            foreach (Plant plant in plants)
            {
                plant.GetStatus();
            }
            Console.WriteLine("");
        }

        public void Water(float totalWaterAmount)
        {
            Console.WriteLine("Watering with {0}.", totalWaterAmount);
            var counter = 0;
            foreach (Plant plant in plants)
            {
                if (plant.IsWaterNeeded())
                {
                    counter++;
                }
            }
            if (counter == 0)
            {
                PrintStatus();
                return;
            }

            var waterPerPlant = totalWaterAmount / counter;
            foreach (Plant plant in plants)
            {
                if (plant.IsWaterNeeded())
                {
                    plant.Water(waterPerPlant);
                }
            }
            PrintStatus();
        }
    }
}
