using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountExercise
{
    public class BankAccount
    {
        private double _balance = 0.00;
        public BankAccount()
        {
        }
        public void Deposit(double amount)
        {
            _balance += amount;
        }
        public double GetBalance()
        {
            return _balance;
        }
    }
    
}
