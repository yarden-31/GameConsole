using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameConsole.Base;

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

            Console.WriteLine("Login Successful!");
            Console.ReadKey();

            Screen next = new GameMenu();
            next.Show();
        }
    }
}
