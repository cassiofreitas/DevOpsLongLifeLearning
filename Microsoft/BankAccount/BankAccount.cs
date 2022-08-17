namespace Classes;

public class BankAccount
{
    public string Number { get; }
    public string Owner { get; set; }
    public decimal Balance
    {
        get
        {
            decimal balance = 0;
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
            }

            return balance;
        }
    }
    /*
    * The accountNumberSeed is a data member
    * It's private, which means it can only be accessed by code inside the BankAccount class.
    * It's a way of separating the public responsibilities(like having an account number) from the
    * private implementation(how account numbers are generated).
    * It's also static, which means it's shared by all of the BankAccount objects.
    */
    private static int accountNumberSeed = 1234567890;
    public BankAccount(string name, decimal initialBalance) //Constructor
    {
        this.Number = accountNumberSeed.ToString();
        accountNumberSeed++;

        this.Owner = name;
        MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
    }
    private List<Transaction> allTransactions = new List<Transaction>();
    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive.");
        }
        var deposit = new Transaction(amount, date, note);
        allTransactions.Add(deposit);
    }
    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
        }
        if (Balance - amount < 0)
        {
            throw new InvalidOperationException("Not sufficient funds for this withdrawal");
        }
        var withdrawal = new Transaction(-amount, date, note);  //it is negative because it is a withdrawal
        allTransactions.Add(withdrawal);
    }
    public string GetAccountHistory()
    {
        // Great example of using the whole namespace
        var report = new System.Text.StringBuilder();

        decimal balance = 0;
        report.AppendLine("Date\t\tAmount\tBalance\tNote");
        foreach (var item in allTransactions)
        {
            balance += item.Amount;
            report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
        }
        return report.ToString();
    }
}
