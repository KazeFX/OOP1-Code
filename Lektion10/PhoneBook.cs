// public class PhoneBook
// {

//     public static List<Contact> contacts = new List<Contact>();
//     public static void Main()
//     {
//         while (true)
//         {
//             Console.WriteLine("ADDRESSBOK v1");
//             Console.WriteLine("-------------");
//             Console.WriteLine("1) Lägg till kontakt");
//             Console.WriteLine("2) Lista kontakter");
//             Console.WriteLine("3) Sök kontakt");
//             Console.WriteLine("4) Ta bort kontakt");
//             Console.WriteLine("5) Avsluta");
//             Console.WriteLine();
//             Console.Write("Val: ");
//             ConsoleKeyInfo input = Console.ReadKey(false);
//             Console.WriteLine();

//             if (input.Key == ConsoleKey.D1 || input.Key == ConsoleKey.NumPad1)
//             {
//                 Console.Write("Namn: ");
//                 string name = Console.ReadLine();
//                 Console.Write("Nummer: ");
//                 string number = Console.ReadLine();
//                 addContact(name, number);
//                 continue;
//             }

//             if (input.Key == ConsoleKey.D2 || input.Key == ConsoleKey.NumPad2)
//             {
//                 Console.WriteLine();
//                 listContacts();
//                 Console.WriteLine();
//             }

//             if (input.Key == ConsoleKey.D3 || input.Key == ConsoleKey.NumPad3)
//             {
//                 Console.WriteLine("Sök namn: ");
//                 Console.WriteLine($"Hittat: {searchContact(Console.ReadLine())}");
//                 Console.WriteLine();
//             }

//             if (input.Key == ConsoleKey.D4 || input.Key == ConsoleKey.NumPad4)
//             {
//                 Console.Write("Kontakt att ta bort: ");
//                 string nameToRemove = Console.ReadLine();
//                 removeContact(nameToRemove);
//                 Console.WriteLine($"{nameToRemove} borttagen.");
//                 Console.WriteLine();
//             }

//             if (input.Key == ConsoleKey.D5 || input.Key == ConsoleKey.NumPad5)
//             {
//                 Environment.Exit(0);
//             }
//         }
//     }

//     static void addContact(string name, string number)
//     {
//         Contact newContact = new();
//         newContact.Name = name;
//         newContact.Phone = number;
//         contacts.Add(newContact);
//     }

//     static void listContacts()
//     {
//         for (int i = 0; i < contacts.Count; i++)
//         {
//             Console.WriteLine($"{contacts[i].updatedAt} - {contacts[i].createdAt} - {contacts[i].Id} : {contacts[i].Name} - {contacts[i].Phone}");
//         }
//     }

//     static string searchContact(string name)
//     {
//         for (int i = 0; i < contacts.Count; i++)
//         {
//             if (contacts[i].Name.Equals(name, StringComparison.CurrentCultureIgnoreCase))
//             {
//                 return $"Kontakt hittad: {contacts[i].Name} - {contacts[i].Phone}";
//                 break;
//             }
//         }
//         return "Ingen kontakt hittad.";
//     }

//     static void removeContact(string name)
//     {
//         for (int i = 0; i < contacts.Count; i++)
//         {
//             if (contacts[i].Name.Equals(name, StringComparison.CurrentCultureIgnoreCase))
//             {
//                 contacts.RemoveAt(i);
//             }
//         }
//     }
// }

// public class Entity
// {
//     public int Id { get; }

//     public DateTime createdAt { get; }

//     public DateTime updatedAt { get; private set; }

//     public Entity()
//     {
//         Id = Random.Shared.Next(1, 1000001);
//         createdAt = DateTime.Now;
//         updatedAt = DateTime.Now;
//     }

//     public void SetUpdatedAt()
//     {
//         updatedAt = DateTime.Now;
//     }

//     public override string ToString()
//     {
//         return $"{Id} - {createdAt} - {updatedAt}";
//     }
// }

// public class Contact : Entity
// {


//     private string? _name;
//     public string? Name
//     {
//         get => _name;
//         set
//         {
//             _name = value;
//             SetUpdatedAt();
//         }
//     }

//     private string? _phone;
//     public string? Phone
//     {
//         get => _phone;
//         set
//         {
//             _phone = value;
//             SetUpdatedAt();
//         }
//     }

//     public override string ToString()
//     {
//         return $"{Id} - {Name} - {Phone} - {createdAt} - {updatedAt}";
//     }

//     public class Adress : Entity
//     {
//         private string? _street;

//         public string? Street
//         {
//             get => _street;
//             set
//             {
//                 _street = value;
//                 SetUpdatedAt();
//             }
//         }

//         private string? _postalCode;

//         public string? PostalCode
//         {
//             get => _postalCode;
//             set
//             {
//                 _postalCode = value;
//                 SetUpdatedAt();
//             }
//         }

//         private string? _city;

//         public string? City
//         {
//             get => _city;
//             set
//             {
//                 _city = value;
//                 SetUpdatedAt();
//             }
//         }
//     }
// }