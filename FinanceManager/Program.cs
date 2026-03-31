
using FinanceManager;

Console.Write("Enter your name: ");
string name = Console.ReadLine();
User user;
if (name == "") {
     user = new User();
}
else {
    user = new User(name);
}

bool isRunning = true;
Console.WriteLine($"Welcome {user.FirstName}! This is your finance manager");
string userChoice;
while (isRunning) {
  MainMenu();
}



void MainMenu() {
    Console.WriteLine($"What you wanna do today?\n1. Add Revenue/Expenses\n2. Check your balance\n3. Exit");
    userChoice = Console.ReadLine();
    switch (userChoice) {
        case "1" :
            break;
        case "2":
            user.GetBalance();
            break;
        case "3" :
            isRunning = false;
            break;
        default:
            Console.WriteLine("Wrong Argument! Please try again\n");
            break;
    }
}


void AddingRevenueOrExpenses() {
    while (true) {
        Console.WriteLine("Add Revenue or Expense, write how many you spend");
        decimal finalResult;
        string result = Console.ReadLine();

        if (decimal.TryParse(result, out finalResult)) {
            
        }
    }
   
}

void chooseCategoryOfRevenue