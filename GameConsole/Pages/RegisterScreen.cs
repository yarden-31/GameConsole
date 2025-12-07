using GameConsole.Base;
using GameConsole.Date;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameConsole.Pages
{
    internal class RegisterScreen : Screen
    {
        private string name;
        private string user;
        private string password;

        public RegisterScreen() : base("Register Screen")
        {

        }

        //-----------------------------------------------------------

        public override void Show()
        {
            base.Show();
            string text = "Register Screen";
            Console.WriteLine("Enter Account Name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter Account User: ");
            user = Console.ReadLine();

            Console.WriteLine("Enter Account Password: ");
            password = Console.ReadLine();

            while (UserDb.RegisterUser(name, user, password) == null)
            {
                Console.WriteLine("This UserName already exists, please enter a new user:");
                user = Console.ReadLine();
            }

            Console.WriteLine("New Account has been made!");

            Console.ReadKey();
        }

    }
}
