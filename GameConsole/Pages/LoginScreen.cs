using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameConsole.Base;
using GameConsole.Date;
using GameConsole.Models;

namespace GameConsole.Pages
{
    internal class LoginScreen : Screen
    {
        public LoginScreen() : base("Login Screen")
        {

        }

        //-----------------------------------------------------------
        public override void Show()
        {
            base.Show();
            string text = "Login Screen";
            Console.WriteLine("Enter Account User: ");
            string user = Console.ReadLine();

            Console.WriteLine("Enter Account Password: ");
            string password = Console.ReadLine();
            User u = UserDb.Login(user, password);
            while ( u== null)
            {
                Console.WriteLine("Invalid UserName or Password, please try again: ");
                Console.WriteLine("Enter Account User: ");
                user = Console.ReadLine();

                Console.WriteLine("Enter Account Password: ");
                password = Console.ReadLine();
                u = UserDb.Login(user, password);
            }
            ConsoleGame.user = u;
            Console.WriteLine("Login Successful!");
            Console.ReadKey();

            Screen next = new GameOrUserActionsMenu();
            next.Show();
        }
    }
}
