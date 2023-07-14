using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmTransaction
{
    public class Atm
    {
        private int accountBalance;
        


        public Atm(int accountBalance)
        {
            this.accountBalance = accountBalance;            
        }


        public void CheckBalance()
        {
            Console.WriteLine("Your account balance is: " + accountBalance + "Rs");
        }

        public void Withdrawal(int amount)
        {
            if (amount % 100 == 0)
            {
                if (amount <= accountBalance)
                {
                    accountBalance -= amount;
                    Console.WriteLine("Withdrawal successful, Remaining balance is: " + accountBalance + "Rs");
                }
                else
                {
                    Console.WriteLine("Insufficient balance, please enter valid amount/ enter amount in 100's\"");
                }
            }
            
        }

        public void Deposit(int amount)
        {
            if (amount % 100 == 0)
            {
                if (amount <= accountBalance)
                {
                    accountBalance += amount;
                    Console.WriteLine("Withdrawal successful, Remaining balance is: " + accountBalance + "Rs");
                }
                else
                {
                    Console.WriteLine("Insufficient balance, please enter valid amount/ enter amount in 100's");
                }

            }               
            
        }

    }
}
