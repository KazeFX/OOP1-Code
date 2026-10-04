class Program
{
    static List<User> users = [
        new(){ Username = "alice" },
        new(){ Username = "bob" },
        new(){ Username = "charlie" }
    ];

    static void Main()
    {
        try
        {
            Console.Write("Ange användarnamn att hitta: ");
            string username = Console.ReadLine();

            User user = FindUser(username);
            Console.WriteLine($"Hittade användaren: {user.Username} med ID {user.Id}");
        }
        catch (KeyNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static User FindUser(string username)
    {

        foreach (User user in users)
        {
            if (user.Username == username)
            {
                return user;
            }
        }

        throw new KeyNotFoundException("User not found!");
    }
}

class User
{
    public int Id { get; set; } = Random.Shared.Next(1, 100);
    public string Username { get; set; }
}
