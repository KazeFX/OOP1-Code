using Microsoft.Data.Sqlite;

using var db = new SqliteConnection("Data Source = database.db");
db.Open();

using SqliteCOmmand 

using SqliteCommand createDb = db.CreateCommand();
createDb.CommandText = """
    CREATE TABLE IF NOT EXISTS People (
        Id INTEGER PRIMARY KEY,
        Name TEXT NOT NULL,
        Age INTEGER NOT NULL
    )
""";
createDb.ExecuteNonQuery();

string name = "Darth Vader";
int age = 100;

using var insertPerson = db.CreateCommand();
insertPerson.CommandText = $"""
    INSERT INTO People (Name, Age)
    VALUES ('{name}', {age})
""";

insertPerson.ExecuteNonQuery();

using var selectPeople = db.CreateCommand();
selectPeople.CommandText = "SELECT Id, Name, Age FROM People";

using SqliteDataReader reader = selectPeople.ExecuteReader();

List<Person> people = [];

while (reader.Read())
{
    Person newPerson = new Person
    {
        Name = reader.GetString(1),
        Age = reader.GetInt32(2)
    };

    people.Add(newPerson);
}

foreach (var item in people)
{
    Console.WriteLine(item);
}

class Person 
{
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return Name + ", " + Age;
    }
}