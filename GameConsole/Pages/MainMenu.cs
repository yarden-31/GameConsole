using GameConsole.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class MainMenu : MenuScreen
    {
        public MainMenu() : base("Main Menu")
        {
            AddMenuItem(new MenuItem("Register", new RegisterScreen()));
            AddMenuItem(new MenuItem("Login", new LoginScreen()));
        }
    }
}
