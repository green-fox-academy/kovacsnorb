using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClubProject.Models
{
    public class Fox
    {
        public string Name { get; set; }
        public List<TricksType> KnownTricks { get; set; } = new List<TricksType>();
        public FoodType Food { get; set; }
        public DrinkType Drink { get; set; }

        //public Fox(string name, List<Trick> trickList, FoodType food, DrinkType drink)
        //{
        //    Name = name;
        //    KnownTricks = trickList;
        //    Food = food;
        //    Drink = drink;
        //}

    }
}
