using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P03BankOfSimba.Models
{
    public class BankAccount
    {
        public BankAccount(string name, double balance, Animal animalType, bool isKing, bool isGoodGuy)
        {
            Name = name;
            Balance = balance;
            AnimalType = animalType;
            Currency = "Zebra";
            IsKing = isKing;
            IsGoodGuy = isGoodGuy;
        }

        public string Name { get; set; }
        public double Balance { get; set; }
        public Animal AnimalType { get; set; }
        public string Currency { get; set; }
        public bool IsKing { get; set; }
        public bool IsGoodGuy { get; set; }

        public double RaiseAccount()
        {
            double newBalance; 
            
            if (IsKing)
            {
                newBalance = Balance + 100;
            }
            else
            {
                newBalance = Balance + 10;
            }
            return newBalance;
        }
    }
}
