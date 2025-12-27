using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameConsole.Base;

namespace GameConsole.Pages
{
    internal class LastGamePlayedDetailsScreen : Screen
    {
        public LastGamePlayedDetailsScreen() : base("Last Game Played Details Screen")
        {
        }
        //-----------------------------------------------------------
        public override void Show()
        {
            base.Show();
            string text = ("Last Game Played Details Screen");
            Console.WriteLine("Last Game Played Details:");
            if (ConsoleGame.user.GameHistory != null && ConsoleGame.user.GameHistory.Count > 0)
            {
                var lastGame = ConsoleGame.user.GameHistory.OrderByDescending(date => date.DatePlayed).First();
                Console.WriteLine($" - Game: {lastGame.GameTitle}, Score: {lastGame.Score}, Date: {lastGame.DatePlayed}");
            }
            else
            {
                Console.WriteLine("No game history available.");
            }

            Console.WriteLine("Press any key to return to the previous menu...");
            Console.ReadKey();
            Screen next = new GameOrUserActionsMenu();
            next.Show();
        }
    }
}
