
class Program
{
    public static void Main()
    {
        Ticket ticket = new Ticket("Konsert", 500);
        ticket.PrintInfo();
        StudentTicket studTicket = new StudentTicket("Konsert", 500);
        studTicket.PrintInfo();
    }
}


public class Ticket
{
    public string EventName { get; set; }
    public int BasePrice { get; set; }

    public Ticket(string eventName, int basePrice)
    {
        EventName = eventName;
        BasePrice = basePrice;
    }

    public virtual int GetPrice()
    {
        return BasePrice;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{EventName}: {GetPrice()} kr");
    }
}

public class StudentTicket : Ticket
{
    public StudentTicket(string eventName, int basePrice) : base(eventName, basePrice) { }

    public override int GetPrice()
    {
        return (int)(BasePrice * 0.8);
    }
}