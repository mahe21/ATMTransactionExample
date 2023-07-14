namespace AtmTransaction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int accountBalance = 1000;


            Atm atm = new Atm(accountBalance);

            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Make a Withdrawal");
            Console.WriteLine("3. Make a Deposit");
            Console.WriteLine("4. Exit");


            while (true)
            {
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        atm.CheckBalance();
                        break;

                    case 2:
                        Console.Write("Enter the withdrawal amount: ");
                        int withdrawalAmount = Convert.ToInt32(Console.ReadLine());
                        atm.Withdrawal(withdrawalAmount);
                        break;

                    case 3:
                        Console.Write("Enter the Deposit amount: ");
                        int depositAmount = Convert.ToInt32(Console.ReadLine());
                        atm.Deposit(depositAmount);
                        break;

                    case 4:
                        Console.WriteLine("Thank you for using the ATM.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
        }
    }
}