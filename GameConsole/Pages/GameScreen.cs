using GameConsole.Base;
using GameConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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
            Console.WriteLine($"Exiting game: {game.Name}");
            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey();
        }

    }
}
