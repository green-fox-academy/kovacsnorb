using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftCarrierProject
{
    class AircraftCarrier
    {
        List<Aircraft> aircraftList;
        protected int StoreOfAmmo;
        protected int HealthPoint;

        public AircraftCarrier(int initialAmmo, int healthPoint)
        {
            aircraftList = new List<Aircraft>();
            StoreOfAmmo = initialAmmo;
            HealthPoint = healthPoint;
        }

        public void AddAircraft(string typeOfAircraft)
        {
            aircraftList.Add(new Aircraft(typeOfAircraft));
        }

        public void Fill()
        {
            if (StoreOfAmmo <= 0)
            {
                Console.WriteLine("The store is empty.");
                return;
            }

            int ammoNeeded = 0;

            foreach (Aircraft aircraft in aircraftList)
            {
                ammoNeeded += aircraft.GetAmmoNeeded();
            }

            if (ammoNeeded > StoreOfAmmo)
            {
                foreach (Aircraft aircraft in aircraftList)
                {
                    if (aircraft.GetType() == "F35")
                    {
                        StoreOfAmmo = aircraft.Refill(StoreOfAmmo);
                    }
                }
            }
            foreach (Aircraft aircraft in aircraftList)
            {
                StoreOfAmmo = aircraft.Refill(StoreOfAmmo);
            }
        }
    }
}
