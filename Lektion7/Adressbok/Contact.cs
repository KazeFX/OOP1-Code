public class Contact
{
    public string Name;
    public string Phone;

    public Contact(string name, string phone)
    {
        if (name == null || name == "" || phone == null || phone == "")
        {
            throw new ArgumentException(nameof(name));
            throw new ArgumentException(nameof(phone));
        }
        else
        {
            Name = name;
            Phone = phone;
        }
    }
}