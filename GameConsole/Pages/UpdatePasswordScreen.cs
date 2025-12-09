using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameConsole.Base;
using GameConsole.Date;

namespace GameConsole.Pages
{
    internal class UpdatePasswordScreen : Screen
    {
        public UpdatePasswordScreen() : base("Update Password Screen")
        {

        }
        //-----------------------------------------------------------
        public override void Show()
        {
            base.Show();
            string text = "Update Password Screen";
            Console.WriteLine("Current Password: " + ConsoleGame.user.Password);
            Console.WriteLine("Enter New Account Password: ");
            string newPassword = Console.ReadLine();
            ConsoleGame.user.Password = newPassword;
            Console.WriteLine($"Account Password has been updated.");
            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey();
            Screen next = new GameOrUserActionsMenu();
            next.Show();
        }
    }
}
