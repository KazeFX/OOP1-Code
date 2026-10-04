
// //1
// using System.Runtime.CompilerServices;

// class Program
// {
//     static void Main()
//     {
//         BankAccount konto = new BankAccount(1000);

//         Console.Write("Hur mycket vill du ta ut? ");
//         int amount = int.Parse(Console.ReadLine());

//         try
//         {
//             konto.Withdraw(amount);
//         }
//         catch (InvalidOperationException)
//         {
//             Console.WriteLine("Saldot räcker inte till!");
//         }
//         finally
//         {
//             Console.WriteLine($"Ditt saldo är nu: {konto.Balance}");
//         }

//         Console.WriteLine(konto.Balance);

//         Console.Write("Hur mycket vill du sätta in?: ");
//         int depAmount = int.Parse(Console.ReadLine());

//         try
//         {
//             if (depAmount < 0)
//                 throw new ArgumentOutOfRangeException(nameof(depAmount));
//             else
//             {
//                 konto.Deposit(depAmount);
//             }
//         }
//         catch (OverflowException)
//         {
//             Console.WriteLine("För stor summa!");
//         }
//         catch (ArgumentOutOfRangeException ex)
//         {
//             Console.WriteLine("Måste vara ett positivt heltal!");
//         }
//         finally
//         {
//             Console.WriteLine($"Ditt saldo är nu: {konto.Balance}");
//         }
//     }
// }

// class BankAccount
// {
//     public int Balance { get; private set; }

//     public BankAccount(int saldo)
//     {
//         Balance = saldo;
//     }

//     public void Withdraw(int amount)
//     {
//         Balance -= amount; // Här ska det egentligen skyddas med exception
//     }

//     public void Deposit(int amount)
//     {
//         Balance += amount;
//     }
// }