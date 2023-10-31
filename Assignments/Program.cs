using System.Security.Principal;

public class Program
{
    static void Main(string[] args)
    {
        Account account1 = new Account();
        Console.WriteLine("Enter account id");
        account1.Id = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter account type");
        account1.AccountType = Console.ReadLine();
        Console.WriteLine("Enter account balance");
        account1.Balance = double.Parse(Console.ReadLine());

        Console.WriteLine(account1.GetDetails());

        Console.WriteLine("Enter amount to withdraw");
        double amountToWithdraw = double.Parse(Console.ReadLine());
        bool result = account1.Withdraw(amountToWithdraw);

        if (result)
        {
            Console.WriteLine("New Balance: " + account1.Balance);
        }
        else
        {
            Console.WriteLine("Insufficient balance. Withdrawal failed.");
        }

        // Create a List of Account objects using List Initializer
        List<Account> accountList = new List<Account>
        {
            new Account { Id = 111, AccountType = "savings", Balance = 500880 },
            new Account { Id = 123, AccountType = "current", Balance = 356788 },
            // Add more accounts here...
        };

        Console.WriteLine("Account Details for all accounts:");
        foreach (var account in accountList)
        {
            Console.WriteLine(account.GetDetails());
        }
    }
}