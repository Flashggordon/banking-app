using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApp
{
    public class BankAccount

    {
      // These are the account's public-facing details (properties)
        public string Name { get; set; }
        public int AccountNumber { get; set; }
        public int AccountTotal { get; private set; }

// This is the constructor — runs when you create a new BankAccount object
        public BankAccount(string name, int accountNumber, int accountTotal)

        {
// Set the account's values based on what gets passed in
         AccountNumber = accountNumber; 
         AccountTotal = accountTotal; 
         Name = name; 
    
        }
    }
}