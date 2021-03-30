using System;

namespace console_bank_see_sharp
{
    public class BankAccount
    {
        public BankAccount(Client client, double balance, string type)
        {
            Client = client;
            _balance = balance;
            Type = type;
        }

        public Client Client { get; }
        private double _balance;
        public string Type { get; set; }

        public double CheckBalance()
        {
            return this._balance;
        }

        public string Withdraw(double withdrawal)
        {
            if ((this._balance - withdrawal) < 0)
            {
                return "Auwtch, there is not enough money on your account. Awkaaaaaard. Come back when you've saves some more.";
            }
            
            else if (withdrawal < 0)
            {
                return "You can't withdraw a negative amount of money from your account. You think we're stupid? Nice try though!";
            }

            this._balance -= withdrawal;
            return $"You, {this.Client.Name}, have just withdrewn (is that a word?) {withdrawal} euro from your {this.Type} so there is only {this.CheckBalance()} euros left on there.";
        }

        public string Deposit(double deposit)
        {
            if (deposit < 0)
            {
                return "You can't add a negative amount of money to your account. Come back when you've looked up the words 'deposit' and 'withdrawal' please and thank you.";
            }

            this._balance += deposit;
            return $"Oooeh, nice fattening of your {this.Type}. You now have {this.CheckBalance()} euros on here.";
        }
    }
}