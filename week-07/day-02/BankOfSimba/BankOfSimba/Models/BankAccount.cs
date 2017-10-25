using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public string Balance { get; set; }
        public string AnimalType { get; set; }
        public string Currency { get; set; }

        public BankAccount(string name, string balance, string animalType, string currency)
        {
            Name = name;
            Balance =  float.Parse(balance).ToString("0.00");
            AnimalType = animalType;
            Currency = currency;
        }

        
    }
}
