// class MenuItem
// {
//     public string Name { get; private set; }
//     public decimal Price { get; private set; }

//     public MenuItem(string name, decimal price)
//     {
//         Name = name;
//         Price = price;
//     }
// }

// class Order
// {
//     public string EatOptions { get; set; }
//     public List<MenuItem> _items = [];
// }

// class Program
// {

//     Order order = new Order();
//     static void Main()
//     {
//         List<MenuItem> menu = [
//             new MenuItem("Pizza", 80),
//             new MenuItem("Pasta", 70),
//             new MenuItem("Salad", 50)
//         ];

//         var order = new Order();

//         EatHereOrTakeAway(order);

//         do
//         {
//             order.AddItem(menu);
//             Console.WriteLine("Vill du lägga till en rätt till? (j/n) ");
//         } while (Console.ReadLine()?.ToLower() == "j");

//         ShowTotal(order);
//     }

//     public static void EatHereOrTakeAway(Order order)
//     {
//         Console.WriteLine("Välj alternativ");
//         Console.WriteLine("1. Äta här");
//         Console.WriteLine("2. Ta med");

//         int val = int.Parse(Console.ReadLine());

//         if (val == 1)
//         {
//             order.EatOptions = "Äta här";
//         }
//         else
//         {
//             order.EatOptions = "Ta med";
//         }

//         Console.WriteLine($"Du valde att: {order.EatOptions.ToLower()}");
//     }

//     public static void ShowMenuItem(MenuItem item)
//     {
//         Console.WriteLine($"{item.Name} - {item.Price} kr");
//     }

//     public static void ShowTotal(List<MenuItem> order)
//     {
//         decimal total = 0;
//         foreach (var item in order)
//         {
//             total += item.Price;
//         }
//         Console.WriteLine($"Totalt pris: {total} kr");
//     }

//     public void AddItem(List<MenuItem> menu, MenuItem item, Order order)
//     {
//         for (int i = 0; i < menu.Count; i++)
//         {
//             Console.Write($"{i + 1}.");
//             ShowMenuItem(menu[i]);
//         }

//         Console.Write("Ange rättens nummer: ");
//         string? nr = Console.ReadLine();

//         if (!int.TryParse(nr, out int index) || index < 1 || index > menu.Count)
//         {
//             Console.WriteLine("Ogiltigt val!");
//             return;
//         }

//         _items.Add(menu[index - 1]);

//         Console.Write($"Lade till: ");
//         ShowMenuItem(menu[index - 1]);
//     }
// }
