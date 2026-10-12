// class VendingMachine
// {
//     private int cans;
//     private int capacity;

//     public VendingMachine()
//     {
//         cans = 10;
//         capacity = 20;
//     }

//     public void Buy()
//     {
//         // Kontrollera om det finns burkar kvar.
//         // Om ja, minska antalet med 1.
//         // Om nej, skriv ett meddelande.
//         if (cans > 0)
//         {
//             cans--;
//         }
//         else
//         {
//             Console.WriteLine("Inga burkar kvar");
//         }
//     }

//     public void Refill(int amount)
//     {
//         // Kontrollera att amount är positivt.
//         // Kontrollera att burkarna får plats.
//         // Fyll i så fall på automaten.
//         if (amount > 0)
//         {
//             if (amount + cans < 20)
//             {
//                 cans += amount;
//             }
//         }
//     }

//     public void ShowStatus()
//     {
//         Console.WriteLine($"{cans} left");
//     }
// }