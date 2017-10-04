using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftCarrierProject
{
    class Aircraft
    {
        protected int MaxAmmo = 8;
        protected int BaseDamage = 30;
        protected int AmmoStore;
        protected string TypeOfAircraft = "F16";
        
        public Aircraft(string typeOfAircraft)
        {
            TypeOfAircraft = typeOfAircraft;
            if (typeOfAircraft == "F35")
            {
                MaxAmmo = 12;
                BaseDamage = 50;
            }
        }

        public int Fight()
        {
            var Damage = BaseDamage * AmmoStore;
            AmmoStore = 0;
            return Damage;
        }

        public int Refill(int number)
        {
            if (AmmoStore + number > MaxAmmo)
            {
                AmmoStore = MaxAmmo;
                return number - MaxAmmo;
            }
            AmmoStore += number;
            return 0;
        }

        public int GetAmmoNeeded()
        {
            return MaxAmmo - AmmoStore;
        }

        public new string GetType()
        {
            return TypeOfAircraft;
        }

        public string GetStatus()
        {
            return "Type" + TypeOfAircraft + ", Ammo: " + AmmoStore + ", Base Damage: " + BaseDamage + ", All Damage: " + Fight();
        }
    }
}
