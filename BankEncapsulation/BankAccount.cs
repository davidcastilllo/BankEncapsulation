namespace BankEncapsulation;

public class BankAccount {

private double balance = 0;
public void Deposit(double amt) {
balance += amt;
}

public void GetBalance() {
 Console.WriteLine($"Your balance is ${balance}.");
}
}