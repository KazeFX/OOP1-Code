
// using System.IO.Compression;
// using System.Reflection.Metadata;

// namespace kazefx;

// public enum Season
// {
//     Spring,
//     Summer,
//     Autumn,
//     Winter
// }

// public enum MenuOption
// {
//     StartGame,
//     LoadGame,
//     Settings,
//     Exit
// }

// public enum PostState
// {
//     Draft,
//     Published,
//     Archived
// }


// public class Program
// {
//     public static void Main()
//     {
//         Season season = Season.Spring;
//         Console.WriteLine(season);

//         SeasonalActivity spring = new SeasonalActivity(Season.Spring, "Skateboarding");
//         SeasonalActivity summer = new SeasonalActivity(Season.Summer, "Jetskiing");
//         SeasonalActivity autumn = new SeasonalActivity(Season.Autumn, "Jamming");
//         SeasonalActivity winter = new SeasonalActivity(Season.Winter, "Snowboarding");

//         Console.WriteLine($"{spring.Season}, {summer.Season}, {autumn.Season}, {winter.Season}");

//         HandleMenuOption(MenuOption.StartGame);
//         HandleMenuOption(MenuOption.LoadGame);
//         HandleMenuOption(MenuOption.Settings);
//         HandleMenuOption(MenuOption.Exit);

//         Console.WriteLine("1. Start Game");
//         Console.WriteLine("2. Load Game");
//         Console.WriteLine("3. Settings");
//         Console.WriteLine("4. Exit");

//         Console.Write("Menu option: ");
//         int option = int.Parse(Console.ReadLine());

//         Console.WriteLine("//////////////////////////");
//         HandleMenuOption((MenuOption)Enum.GetValues(typeof(MenuOption)).GetValue(option - 1));

//         BlogPost blog = new BlogPost("Heyo", "NERDS");
//         Console.WriteLine(blog.State);
//         blog.Publish();
//         Console.WriteLine(blog.State);

//     }

//     static void HandleMenuOption(MenuOption option)
//     {
//         switch (option)
//         {
//             case MenuOption.StartGame:
//                 Console.WriteLine("Starting game!");
//                 break;
//             case MenuOption.LoadGame:
//                 Console.WriteLine("Loading game!");
//                 break;
//             case MenuOption.Settings:
//                 Console.WriteLine("Entering Settings!");
//                 break;
//             case MenuOption.Exit:
//                 Console.WriteLine("Exiting game!");
//                 break;
//         }
//     }
// }

// public class SeasonalActivity
// {
//     public Season Season { get; set; }

//     public string Activity { get; set; }

//     public SeasonalActivity(Season season, string activity)
//     {
//         Season = season;
//         Activity = activity;
//     }
// }

// public class BlogPost
// {
//     public string Title;
//     public string Content;
//     public PostState State;

//     public BlogPost(string title, string content)
//     {
//         Title = title;
//         Content = content;
//         State = PostState.Draft;
//     }

//     public void Publish()
//     {
//         State = PostState.Published;
//     }

//     public void Archive()
//     {
//         State = PostState.Archived;
//     }
// }