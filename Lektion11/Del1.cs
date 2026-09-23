// namespace Lektion11;

// class Program
// {
//     static void Main(string[] args)
//     {
//         //Exercise1();
//         //Exercise2();
//         //Exercise3();

//     }

//     static void Exercise1()
//     {
//         string input = "";
//         while (true)
//         {
//             try
//             {
//                 Console.Write("Skriv in ett heltal: ");
//                 input = Console.ReadLine();
//                 int tal = int.Parse(input);
//                 Console.WriteLine($"Du skrev in talet: {tal}");
//                 break;
//             }
//             catch (FormatException)
//             {
//                 Console.WriteLine("Inte ett heltal!");
//                 continue;
//             }
//             catch (OverflowException)
//             {
//                 Console.WriteLine("Talet är för stort!");
//                 continue;
//             }
//         }
//     }

//     static void Exercise2()
//     {

//         while (true)
//         {
//             try
//             {
//                 Console.Write("Skriv in ett heltal: ");
//                 int tal1 = int.Parse(Console.ReadLine());

//                 Console.Write("Skriv in ett heltal till: ");
//                 int tal2 = int.Parse(Console.ReadLine());

//                 int resultat = tal1 / tal2;
//                 Console.WriteLine($"Resultatet blev: {resultat}");
//             }
//             catch (FormatException)
//             {
//                 Console.WriteLine("Inte ett heltal!");
//             }
//             catch (DivideByZeroException)
//             {
//                 Console.WriteLine("Kan inte dela med 0!");
//             }
//             catch (OverflowException)
//             {
//                 Console.WriteLine("Talet är för stort!");
//             }
//         }
//     }

//     static void Exercise3()
//     {
//         while (true)
//         {
//             try
//             {
//                 Console.Write("Ange filnamn: ");
//                 string filnamn = Console.ReadLine();
//                 string innehåll = File.ReadAllText($"C:\\Users\\d34th\\Code\\OOP1\\Lektion11\\{filnamn}");
//                 Console.WriteLine("Filens innehåll:");
//                 Console.WriteLine(innehåll);
//             }
//             catch (FileNotFoundException)
//             {
//                 Console.WriteLine("Hittar inte filen!");
//             }
//             catch (UnauthorizedAccessException)
//             {
//                 Console.WriteLine("Du saknar rättigheter att läsa filen!");
//             }
//         }
//     }
// }