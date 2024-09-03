namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount();
            myAccount.Deposit(1000);
            Console.WriteLine($"My Account balance is {myAccount.GetBalance()}");
        }
    }
}
