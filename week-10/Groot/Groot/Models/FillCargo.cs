using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Groot.Models
{
    public class FillCargo
    {
        private static readonly int MAXAMOUNT = 12500;
        public string received;
        public double amount = 0;
        public string shipstatus;
        public bool ready;

        public FillCargo(string received, int amount)
        {
            this.received = received;
            this.amount = this.amount + amount;
            shipstatus = GetShipStatus();
            this.ready = GetReadyStatus();
        }

        public string GetShipStatus()
        {
            double loadPercentage = amount/MAXAMOUNT;
            if (loadPercentage == 0)
            {
                return shipstatus = "empty";
            }
            else if (loadPercentage == 1)
            {
                return shipstatus = "full";
            }
            else if (loadPercentage > 1)
            {
                return shipstatus = "overloaded";
            }
            else
            {
                return shipstatus = loadPercentage.ToString();
            }
        }

        public bool GetReadyStatus()
        {
            if (shipstatus == "full")
            {
                return ready = true;
            }
            else
            {
                return ready = false;
            }
        }
    }
}
