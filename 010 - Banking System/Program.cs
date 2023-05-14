using System.Runtime.CompilerServices;
using System.IO;
using System.Reflection.Metadata.Ecma335;

namespace BankAccount
{
 public abstract class Account
    {
        protected decimal balance;
        public Account( decimal balance)
        {
            this.balance = balance;
        }
        public virtual void Deposit( decimal amount)
        {
            balance += amount;
        }
        public virtual bool Withdraw( decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                return true;
            }
            else
            {
                Console.WriteLine("Insufficient funds");
                return false;
            }
        }
        public decimal GetBalance()
        {
            return balance;
        }


  }
    public class CheckingAccount : Account
    {
       public CheckingAccount(decimal balance) : base(balance) { }
    }
    public class SavingsAccount : Account
    {
        private decimal interestRate;
       public SavingsAccount(decimal balance, decimal interestRate) : base(balance)
       {
            this.interestRate= interestRate;
       }
        public void AddInterest()
        {
            decimal interest = interestRate * balance;
            Deposit(interest);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount checking = new CheckingAccount(5000);
            checking.Deposit(1000);
            checking.Withdraw(500);
            Console.WriteLine("Checking balance: "+ checking.GetBalance());
            SavingsAccount savings = new SavingsAccount(3000, 0.02m);
            savings.Deposit(500);
            savings.AddInterest();
            savings.Withdraw(3000);
            Console.WriteLine("Savings balance: "+ savings.GetBalance());
        }
    }
}