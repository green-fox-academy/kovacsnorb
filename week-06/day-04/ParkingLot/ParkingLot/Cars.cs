using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class Cars
    {
        public string CarType { get; set; }
        public string CarColor { get; set; }
        private static readonly Random rnd = new Random();

        public Cars()
        {
            this.CarType = ((CarTypes)rnd.Next(0, 3)).ToString();
            this.CarColor = ((CarColors)rnd.Next(0, 3)).ToString();
        }

        public enum CarTypes
        {
            Opel,
            Lada,
            Fiat
        }

        public enum CarColors
        {
            Black,
            White,
            Green
        }
    }
}
