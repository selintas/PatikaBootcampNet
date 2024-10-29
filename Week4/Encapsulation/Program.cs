using Encapsulation;

public class Program
{
    public static void Main(string[]  args)
    {
        BankAccount bankAccount = new BankAccount("Murat", 100, "yyyymmdddydydyd");

        bankAccount.DisplayBalance();

        bankAccount.Deposit(500);

        bankAccount.Withdraw(400);

        bankAccount.DisplayBalance();

        bankAccount.Withdraw(500);
    }
}