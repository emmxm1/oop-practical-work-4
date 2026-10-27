using System.Globalization;
CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
string[] t = Console.In.ReadToEnd() 
    .Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
BankAccount acc = new 
BankAccount(decimal.Parse(t[0]));

string r1 = acc.Deposit(decimal.Parse(t[1])) ? "OK" : "FAIL"; 
string r2 = acc.Withdraw(decimal.Parse(t[2])) ? "OK" : "FAIL";
Console.WriteLine($"{r1} {r2} {acc.Balance}");
public class BankAccount 
{ 
    public decimal Balance { get; private set; }

    public BankAccount(decimal balance)
{
    Balance = balance;
}

public bool Deposit(decimal amount)
{
    if (amount > 0)
    {
        Balance += amount;
        return true;
    }
    return false;
}

public bool Withdraw(decimal amount)
{
    if (amount > 0 && amount <= Balance)
    {
        Balance -= amount;
        return true;
    }
    return false;
}
}
