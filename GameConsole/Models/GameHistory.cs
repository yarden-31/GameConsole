using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Models
{
    internal class GameHistory
    {
        public string GameTitle { get; set; }

        public int Score { get; set; }

        public DateTime DatePlayed { get; set; }

        //-----------------------------------------------------------

        public GameHistory(string gameTitle, int score)
        {
            GameTitle = gameTitle;
            Score = score;
            DatePlayed = DateTime.Now;
        }

        //-----------------------------------------------------------
    }
}
