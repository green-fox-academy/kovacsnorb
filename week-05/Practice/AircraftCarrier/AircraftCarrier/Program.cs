using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftCarrierProject
{
    class Program
    {
        static void Main(string[] args)
        {
            AircraftCarrier carrier = new AircraftCarrier(35, 4000);
            carrier.AddAircraft("F16");
            carrier.AddAircraft("F16");
            carrier.AddAircraft("F35");
            carrier.AddAircraft("F35");
            carrier.AddAircraft("F35");

            carrier.Fill();

            Console.WriteLine(Console.ReadLine());
        
        }
    }
}
