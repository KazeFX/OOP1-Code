
// class Tickets
// {
//     public static void Main()
//     {
//         List<Ticket> ticketList = new List<Ticket>();

//         ticketList.Add(new Ticket("Konsert", 500));
//         ticketList.Add(new StudentTicket("Konsert", 500));
//         ticketList.Add(new VipTicket("Konsert", 500, "20"));
//         foreach (Ticket ticket in ticketList)
//         {
//             ticket.PrintInfo();
//         }
//     }
// }

// public class Ticket
// {
//     public string EventName { get; set; }
//     public int BasePrice { get; set; }

//     public Ticket(string eventName, int basePrice)
//     {
//         EventName = eventName;
//         BasePrice = basePrice;
//     }

//     public virtual int GetPrice()
//     {
//         return BasePrice;
//     }

//     public virtual void PrintInfo()
//     {
//         Console.WriteLine($"{EventName}: {GetPrice()} kr");
//     }
// }

// public class StudentTicket : Ticket
// {
//     public StudentTicket(string eventName, int basePrice) : base(eventName, basePrice) { }

//     public override int GetPrice()
//     {
//         return (int)(BasePrice * 0.8);
//     }
// }

// public class VipTicket : Ticket
// {
//     public string SeatNumber { get; set; }
//     public bool IncludesDrink { get; set; }


//     public VipTicket(string eventName, int basePrice, string SeatNumber) : base(eventName, basePrice)
//     {
//         this.SeatNumber = SeatNumber;
//     }

//     public override int GetPrice()
//     {
//         if (this.IncludesDrink == true)
//         {
//             return BasePrice + 400;
//         }
//         else
//         {
//             return BasePrice + 300;
//         }
//     }

//     public override void PrintInfo()
//     {
//         base.PrintInfo();
//         Console.WriteLine($"Seat: {SeatNumber}");
//     }
// }

// public class ChildTicket : Ticket
// {
//     public ChildTicket(string eventName, int basePrice) : base(eventName, basePrice) { }

//     public override int GetPrice()
//     {
//         return BasePrice / 2;
//     }
// }