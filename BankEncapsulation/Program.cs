namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var userOne = new BankAccount();
            userOne.Deposit(100.00);

            userOne.GetBalance();
        }
    }
}
