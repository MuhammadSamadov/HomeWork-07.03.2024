namespace task1;

public class Account
{
    double _balance;
    public Account(double balance)
    {
        _balance=balance;
    }
    public void AddSum(double amount)
    {
        _balance+=amount;
    }
    public double GetBalance()
    {
        return _balance;
    }
}
