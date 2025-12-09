using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameConsole.Base;

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
            string text = "User Details Screen";
            Console.WriteLine($"User Details for: {ConsoleGame.user.Name}");
            Console.WriteLine($"Username: {ConsoleGame.user.UserName}");
            Console.WriteLine($"Name: {ConsoleGame.user.Name}");
            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey();
            Screen next = new GameOrUserActionsMenu();
            next.Show();


        }
    }
}
