using System;
using System.Collections.Generic;

public class Account
{
    private int id;
    private string accountType;
    private double balance;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string AccountType
    {
        get { return accountType; }
        set { accountType = value; }
    }

    public double Balance
    {
        get { return balance; }
        set { balance = value; }
    }

    public bool Withdraw(double amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            return true;
        }
        return false;
    }

    public string GetDetails()
    {
        return $"Account Id: {id}\nAccount Type: {accountType}\nBalance: {balance}";
    }
}

