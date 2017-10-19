using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            var myParkingLot = FillListWithCars();
            var countTypeFrequency = myParkingLot.GroupBy(x => x.CarType).ToDictionary(x => x.Key, x => x.Count());
            var countColorFrequency = myParkingLot.GroupBy(x => x.CarColor).ToDictionary(x => x.Key, x => x.Count());

            var myConcate = new List<string>();

            foreach (Cars car in myParkingLot)
            {
                myConcate.Add(car.CarColor + " " + car.CarType);
            }

            var concateList = myConcate.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
            var mostFrequentCarOnly = concateList.FirstOrDefault(x => x.Value == concateList.Values.Max()).Key;

            Console.WriteLine($"Most frequent car is {mostFrequentCarOnly} with {concateList.Values.Max()} cars.\n");

            foreach (var listelement in concateList)
            {
                Console.WriteLine(listelement);
            }

            Console.ReadLine();
        }

        public static List<Cars> FillListWithCars()
        {
            List<Cars> myList = new List<Cars>();

            do
            {
                myList.Add(new Cars());
            } while (myList.Count < 256);

            return myList;
        }
    }
}
