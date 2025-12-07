using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameConsole.Base;
using GameConsole.Date;

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

            while (UserDb.Login(user, password) == null)
            {
                Console.WriteLine("Invalid UserName or Password, please try again: ");
                Console.WriteLine("Enter Account User: ");
                user = Console.ReadLine();

                Console.WriteLine("Enter Account Password: ");
                password = Console.ReadLine();
            }

            Console.WriteLine("Login Successful!");
            Console.ReadKey();

            Screen next = new GameMenu();
            next.Show();
        }
    }
}
