

public class Program
{

    public static List<Contact> contacts = new List<Contact>();
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("ADDRESSBOK v1");
            Console.WriteLine("-------------");
            Console.WriteLine("1) Lägg till kontakt");
            Console.WriteLine("2) Lista kontakter");
            Console.WriteLine("3) Sök kontakt");
            Console.WriteLine("4) Ta bort kontakt");
            Console.WriteLine("5) Avsluta");
            Console.WriteLine();
            Console.Write("Val: ");
            ConsoleKeyInfo input = Console.ReadKey(false);
            Console.WriteLine();

            if (input.Key == ConsoleKey.D1 || input.Key == ConsoleKey.NumPad1)
            {
                try
                {
                    Console.Write("Namn: ");
                    string name = Console.ReadLine();
                    Console.Write("Nummer: ");
                    string number = Console.ReadLine();
                    addContact(name, number);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Namn och nummer kan inte vara tomt!");
                }
                continue;
            }

            if (input.Key == ConsoleKey.D2 || input.Key == ConsoleKey.NumPad2)
            {
                Console.WriteLine();
                listContacts();
                Console.WriteLine();
            }

            if (input.Key == ConsoleKey.D3 || input.Key == ConsoleKey.NumPad3)
            {
                Console.WriteLine("Sök namn: ");
                Console.WriteLine($"Hittat: {searchContact(Console.ReadLine())}");
                Console.WriteLine();
            }

            if (input.Key == ConsoleKey.D4 || input.Key == ConsoleKey.NumPad4)
            {
                Console.Write("Kontakt att ta bort: ");
                string nameToRemove = Console.ReadLine();
                removeContact(nameToRemove);
                Console.WriteLine($"{nameToRemove} borttagen.");
                Console.WriteLine();
            }

            if (input.Key == ConsoleKey.D5 || input.Key == ConsoleKey.NumPad5)
            {
                Environment.Exit(0);
            }
        }
    }


    static void addContact(string name, string number)
    {
        Contact newContact = new(name, number);
        contacts.Add(newContact);
    }


    static void listContacts()
    {
        for (int i = 0; i < contacts.Count; i++)
        {
            Console.WriteLine($"{contacts[i].Name} - {contacts[i].Phone}");
        }
    }


    static string searchContact(string name)
    {
        for (int i = 0; i < contacts.Count; i++)
        {
            if (contacts[i].Name.Equals(name, StringComparison.CurrentCultureIgnoreCase))
            {
                return $"Kontakt hittad: {contacts[i].Name} - {contacts[i].Phone}";
                break;
            }
        }
        return "Ingen kontakt hittad.";
    }


    static void removeContact(string name)
    {
        for (int i = 0; i < contacts.Count; i++)
        {
            if (contacts[i].Name.Equals(name, StringComparison.CurrentCultureIgnoreCase))
            {
                contacts.RemoveAt(i);
            }
        }
    }
}