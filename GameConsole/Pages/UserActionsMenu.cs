using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameConsole.Base;

namespace GameConsole.Pages
{
    internal class UserActionsMenu : MenuScreen
    {
        public UserActionsMenu() : base("User Actions Menu")
        {
            AddMenuItem(new MenuItem("Update Name", new UpdateNameScreen()));
            AddMenuItem(new MenuItem("Update Password", new UpdatePasswordScreen()));
            AddMenuItem(new MenuItem("Show User Details", new UserDetailsScreen()));
        }
    }
}
