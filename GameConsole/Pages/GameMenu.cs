using GameConsole.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class GameMenu : GameMenuScreen
    {
        public GameMenu() : base("Game Menu")
        {
            AddMenuItem(new MenuItem("Tetris", new GameScreen(new Games.TetrisGame())));
            AddMenuItem(new MenuItem("Fluffy Bird", new GameScreen(new Games.FluffyBirdGame())));
            AddMenuItem(new MenuItem ("Pac-Man", new GameScreen (new Games.PacManGame())));
        }

      
    }
}
