using System;
// Ensure the BankApp namespace is defined in your project or referenced correctly
using BankApp;

class Program
{
    // this starts the program 
    static void Main(string[] args)
    {
    
        BankAccount account = new BankAccount("George", 60345784, 100);
        Console.WriteLine("Account name: " + account.Name + "Account Number: " account.AccountNumber);
    }
}

