using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameConsole.Base;

namespace GameConsole.Pages
{
    internal class GameOrUserActionsMenu : MenuScreen
    {
        public GameOrUserActionsMenu() : base("Game or User Actions Menu")
        {
            AddMenuItem(new MenuItem("Game Menu", new GameMenu()));
            AddMenuItem(new MenuItem("User Actions Menu", new UserActionsMenu()));
        }
    }
}
