using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameConsole.Base;

namespace GameConsole.Pages
{
    internal class WelcomeScreen : Screen
    {
        public WelcomeScreen() : base("Welcome!")
        {

        }

        //-----------------------------------------------------------

        public override void Show()
        {
            base.Show();
            string text = "Welcome to the game console application";
            CenterText(text);

            CenterText("Press any keys to continue...");

            Console.ReadKey();
            Screen nextScreen = new MainMenu();
            nextScreen.Show();
            Console.Clear();
            Console.WriteLine("You have exited the game console. Goodbye!");
        }
    }
}
