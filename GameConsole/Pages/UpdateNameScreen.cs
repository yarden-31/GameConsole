using GameConsole.Base;
using GameConsole.Date;
using GameConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GameConsole.Pages
{
    internal class UpdateNameScreen : Screen
    {
        //-----------------------------------------------------------

        public UpdateNameScreen() : base("Update Name Screen")
        {

        }

        //-----------------------------------------------------------

        public override void Show()
        {
            base.Show();

            Console.ForegroundColor = ConsoleColor.Cyan;

            string text = "Update Name Screen";
            Console.WriteLine("Enter New Account Name: ");
            string newName = Console.ReadLine();
            ConsoleGame.user.Name = newName;
            Console.WriteLine($"Account Name has been updated to: {newName}");
            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey();
            Screen next = new GameOrUserActionsMenu();
            next.Show();

        }
    }
}
