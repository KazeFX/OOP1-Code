// List<IInteractable> allInteractableObjects = [new Door(), new NPC(), new Chest(), new Teleporter(), new Lever(), new Lever()];

// IInteractable nearestObject = allInteractableObjects[4];

// for (int i = 0; i < allInteractableObjects.Count; i++)
// {
//     System.Console.WriteLine($"{i + 1}. {allInteractableObjects[i].ToString()}");
// }

// switch (Console.ReadLine())
// {
//     case "1":

//         do
//         {
//             allInteractableObjects.ElementAt(0).Interact();
//         } while (Console.ReadLine() != "q");
//         break;
// }

// foreach (var item in allInteractableObjects)
// {
//     item.Interact();
// }

// if (Console.ReadLine() == "i")
// {
//     nearestObject.Interact();
// }

// interface IInteractable
// {
//     void Interact();
// }

// class Door : IInteractable
// {
//     public bool IsOpen { get; set; }

//     public void Interact()
//     {
//         Console.WriteLine("You open the door!");
//     }
// }

// class NPC : IInteractable
// {
//     public string Name { get; set; }

//     public void Interact()
//     {
//         Console.WriteLine($"{Name} SAYS BlablbalbaLBAL");
//     }
// }

// class Chest : IInteractable
// {
//     // public List<Loot> Loot { get; set; }

//     public void Interact()
//     {
//         Console.WriteLine("You find a trisslott!");
//     }
// }

// class Teleporter : IInteractable
// {
//     public string Destination { get; set; } = "The void";

//     public void Interact()
//     {
//         Console.WriteLine($"You where teleported to {Destination}!");
//     }
// }

// class Lever : IInteractable
// {
//     private bool LeverState { get; set; }
//     public void Interact()
//     {
//         if (LeverState == false)
//         {
//             LeverState = true;
//             Console.WriteLine("You pull the lever and it is ON!");
//         }
//         else
//         {
//             LeverState = false;
//             Console.WriteLine("You pull the lever and it is OFF!");
//         }
//     }
// }