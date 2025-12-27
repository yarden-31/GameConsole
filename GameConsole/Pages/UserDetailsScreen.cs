using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameConsole.Base;
using GameConsole.Models;

namespace GameConsole.Pages
{
    internal class UserDetailsScreen : Screen
    {
        public UserDetailsScreen() : base("User Details Screen")
        {

        }
        //-----------------------------------------------------------
        public override void Show()
        {
            base.Show();

            Console.ForegroundColor = ConsoleColor.Cyan;

            string text = "User Details Screen";
            Console.WriteLine($"User Details for: {ConsoleGame.user.Name}");
            Console.WriteLine($"Username: {ConsoleGame.user.UserName}");
            Console.WriteLine($"Name: {ConsoleGame.user.Name}");
            Console.WriteLine("High Scores:");
            var hsList = ConsoleGame.user.HighScores;
            hsList = hsList.OrderByDescending(hs => hs.Score).ToList();
            foreach (HighScore hs in hsList)
            {
                Console.WriteLine($" - Game: {hs.GameTitle}, Score: {hs.Score}, Date: {hs.DatePlayed}");
            }
            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey();
            Screen next = new GameOrUserActionsMenu();
            next.Show();


        }
    }
}
