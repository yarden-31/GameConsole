using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameConsole.Base;

namespace GameConsole.Pages
{
    internal class GameHistoryMenu : MenuScreen
    {
        public GameHistoryMenu() : base("Game History Menu")
        {
            AddMenuItem(new MenuItem("View Game History by name", new GameHistoryByNameScreen()));
            AddMenuItem(new MenuItem("View Game History by score", new GameHistoryByScoreSCreen()));
            AddMenuItem(new MenuItem("Last Game Played Details", new LastGamePlayedDetailsScreen()));
        }
    }
}
