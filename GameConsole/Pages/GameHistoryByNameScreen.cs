using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameConsole.Base;

namespace GameConsole.Pages
{
    internal class GameHistoryByNameScreen : Screen
    {
        public GameHistoryByNameScreen() : base("Game History By Name Screen")
        {
        }
        //-----------------------------------------------------------
        public override void Show()
        {
            base.Show();
            string text = ("Game History By Name Screen");
            if (ConsoleGame.user.GameHistory != null)
            {
                var sortedGames = ConsoleGame.user.GameHistory.OrderBy(name => name.GameTitle).ToList();
                Console.WriteLine("Game History Sorted by Name:");
                foreach (var game in sortedGames)
                {
                    Console.WriteLine($" - Game: {game.GameTitle}, Score: {game.Score}, Date: {game.DatePlayed}");
                }
            }
            Console.WriteLine("Press any key to return to the previous menu...");
            Console.ReadKey();
            Screen next = new GameOrUserActionsMenu();
            next.Show();
        }
    }
}
