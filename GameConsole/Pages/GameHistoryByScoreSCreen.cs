using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameConsole.Base;

namespace GameConsole.Pages
{
    internal class GameHistoryByScoreSCreen : Screen
    {
        public GameHistoryByScoreSCreen() : base("Game History By Score Screen")
        {
        }
        //-----------------------------------------------------------
        public override void Show()
        {
            base.Show();
            string text = ("Game History By Score Screen");
            if (ConsoleGame.user.GameHistory != null)
            {
                var sortedGames = ConsoleGame.user.GameHistory.OrderByDescending(score => score.Score).ToList();
                Console.WriteLine("Game History Sorted by Score:");
                foreach (var game in sortedGames)
                {
                    Console.WriteLine($" - Game: {game.GameTitle}, Score: {game.Score}, Date: {game.DatePlayed}");
                }
            }
            Console.WriteLine("Press any key to return to the previous menu...");
            Console.ReadKey();
            Screen next = new GameHistoryMenu();
            next.Show();
        }
    }
}
