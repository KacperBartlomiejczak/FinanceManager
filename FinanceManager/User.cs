namespace FinanceManager;

public class User {
    public string FirstName { get; private set; } = "user 1";
    public List<Transactions> TransactionHistory { get; private set; } = new List<Transactions>();
    public decimal Balance => TransactionHistory.Sum(t => t.Price);

    public User(string firstName) {
        this.FirstName = firstName;
    }

    public User() : this("user 1") {}

    public void GetBalance() {
        Console.WriteLine($"Your account balance is: {this.Balance}");
    }

    public void Revenue(string title, decimal price, Category category) {
        this.TransactionHistory.Add(new Transactions(title, price, category));
    }
}