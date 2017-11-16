using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Groot.Models
{
    public class CalculateSpeed : IGroot
    {
        public double distance;
        public double time;
        public double speed;

        public CalculateSpeed(double distance, double time)
        {
            this.distance = distance;
            this.time = time;
            speed = distance / time;
        }
    }
}
