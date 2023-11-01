public class AccountFunction
{ 
    static void Main(string[] args)
    {
        AccountDetail account1 = new AccountDetail();
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
            Console.WriteLine("Balance after withdrawl " + account1.Balance);
        }
        else
        {
            Console.WriteLine("No withdrawl");
        }

       
    }
}