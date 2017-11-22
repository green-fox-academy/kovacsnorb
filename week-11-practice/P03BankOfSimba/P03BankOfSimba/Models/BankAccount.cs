using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P03BankOfSimba.Models
{
    public class BankAccount
    {
        public BankAccount(string name, int balance, Animal animalType)
        {
            Name = name;
            Balance = balance;
            AnimalType = animalType;
        }

        public string Name { get; set; }
        public int Balance { get; set; }
        public Animal AnimalType { get; set; }
    }
}
