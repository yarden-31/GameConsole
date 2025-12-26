using GameConsole.Base;
using GameConsole.Interfaces;
using GameConsole.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class GameScreen : Screen
    {
        private IGamePlay game;

        public GameScreen(IGamePlay game) : base($"Playing {game.Name}")
        {
            this.game = game;
        }

        //-----------------------------------------------------------

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Press any key to start the game...");
            Console.ReadKey();
            Console.WriteLine($"Starting game: {game.Name}");
            game.Play();
            int score = game.Score;
            Console.WriteLine($"Your Score: {score}");
            if (ConsoleGame.user != null)
            {
                HighScore highScore = new HighScore(game.Name, score)
                {
                    GameTitle = game.Name,
                    Score = score,
                    DatePlayed = DateTime.Now
                };
                ConsoleGame.user.HighScores.Add(highScore);
                Console.WriteLine("High score recorded!");
            }
            else
            {
                Console.WriteLine("No user logged in. High score not recorded.");
            }

            if (ConsoleGame.user != null)
            {
                GameHistory gameHistory = new GameHistory(game.Name, score)
                {
                    GameTitle = game.Name,
                    Score = score,
                    DatePlayed = DateTime.Now
                };
                ConsoleGame.user.GameHistory.Add(gameHistory);
            }

            Console.WriteLine($"Exiting game: {game.Name}");
            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey();
            Screen next = new GameOrUserActionsMenu();
            next.Show();
        }

    }
}
