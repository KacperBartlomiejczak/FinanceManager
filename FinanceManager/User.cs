namespace FinanceManager;

public class User {
    public string FirstName { get; private set; } = "user 1";
    public List<Transactions> TransactionHistory { get; private set; } = new List<Transactions>();
    public decimal Balance => TransactionHistory.Sum(t => t.price);

    public User(string firstName) {
        this.FirstName = firstName;
    }

    public void GetBalance() {
        Console.WriteLine(this.Balance);
    }
}