
// abstract class Animal
// {
//     public string Name { get; set; }

//     public abstract string MakeSound();
// }

// class Dog : Animal
// {

//     public override string MakeSound()
//     {
//         return "Bark!";
//     }
// }

// class Cat : Animal
// {
//     public override string MakeSound()
//     {
//         return "Meow!";
//     }
// }

// public class Program
// {
//     public static void Main()
//     {
//         List<Animal> animals = new List<Animal>
//         {
//             new Dog { Name = "Osci" },
//             new Cat() { Name = "Chester" },
//             new Cat() { Name = "Neko" },
//             new Cat() { Name = "Niko" },
//             new Dog() { Name = "Caro"}
//         };

//         foreach (Animal animal in animals)
//         {
//             Console.WriteLine($"{animal.Name}: {animal.MakeSound()}");
//         }
//     }
// }