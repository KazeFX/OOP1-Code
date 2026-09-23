
//1
class Program
{
    static void Main()
    {
        BankAccount konto = new BankAccount(1000);

        Console.Write("Hur mycket vill du ta ut? ");
        int amount = int.Parse(Console.ReadLine());

        try
        {
            konto.Withdraw(amount);
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("Saldot räcker inte till!");
        }
        finally
        {
            Console.WriteLine($"Ditt saldo är nu: {konto.Balance}");
        }

        konto.Deposit(100);

        Console.WriteLine(konto.Balance);
    }
}

class BankAccount
{
    public int Balance { get; private set; }

    public BankAccount(int saldo)
    {
        Balance = saldo;
    }

    public void Withdraw(int amount)
    {
        Balance -= amount; // Här ska det egentligen skyddas med exception
    }

    public void Deposit(int amount)
    {
        try
        {
            this.Balance += amount;
        }
        catch (OverflowException)
        {
            Console.WriteLine("För stor summa!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Måste vara ett heltal!");
        }
    }
}