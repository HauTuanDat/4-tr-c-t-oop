namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> accounts = new List<BankAccount>();
          
            Console.WriteLine("Enter account number:");
            int accountNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter owner name:");
            string ownerName = Console.ReadLine();
            Console.WriteLine("Enter initial balance:");
            decimal initialBalance = decimal.Parse(Console.ReadLine());

            BankAccount account = new BankAccount(accountNumber, ownerName);
            accounts.Add(account);
            bool runing = true;
            while (runing)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Display Account Info");
                Console.WriteLine("4. Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter deposit amount:");
                        decimal depositAmount = decimal.Parse(Console.ReadLine());
                        account.Deposit(depositAmount);
                        break;
                    case 2:
                        Console.WriteLine("Enter withdrawal amount:");
                        decimal withdrawAmount = decimal.Parse(Console.ReadLine());
                        account.Withdraw(withdrawAmount);
                        break;
                    case 3:
                        account.DisplayAccountInfo();
                        break;
                    case 4:
                        runing = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
