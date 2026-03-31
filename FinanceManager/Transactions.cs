namespace FinanceManager;

public class Transactions {
    public string Title;
    public decimal Price;
    public Category Category;

    public Transactions(string title, decimal price, Category category) {
        this.Title = title;
        this.Price = price;
        this.Category = category;
    }
    
}