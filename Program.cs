using System;
using System.Threading.Channels;

namespace console_bank_see_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // creating a new client/bankaccount
            Console.WriteLine("Hello there, do you want to create a bank account today? (yes/no)");
            var answer = Console.ReadLine();

            Console.WriteLine(answer == "yes" ? "Awesome! What's your name?" : "Too bad. Come back soon!");
            if(answer != "yes") { Environment.Exit(0);}

            var name = Console.ReadLine();
            
            Client client = new Client(1, name, DateTime.Now);
            BankAccount bankAccount = new BankAccount(client, 1000, "checking account");
            
            // deposit
            Console.WriteLine($"Welcome {bankAccount.Client.Name}! To get you started, we already put {bankAccount.CheckBalance()} euros on you bank account. How much more do you want to deposit?");
            var deposit = Console.ReadLine();
            Console.WriteLine(bankAccount.Deposit(Convert.ToDouble(deposit)));
            
            // withdraw
            Console.WriteLine("How much money do you want to withdraw today?");
            var withdrawal = Console.ReadLine();
            Console.WriteLine(bankAccount.Withdraw(Convert.ToDouble(withdrawal)));

            Console.WriteLine("That's all for today. Our code is tired. Come back soon though!");
        }
    }
}
