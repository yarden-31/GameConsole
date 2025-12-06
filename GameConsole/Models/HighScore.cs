using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Models
{
    internal class HighScore
    {
        public string GameTitle { get; set; }

        public int Score { get; set; }

        public DateTime DatePlayed { get; set; }

        //-----------------------------------------------------------

        public HighScore(string gameTitle, int score)
        {
            GameTitle = gameTitle;
            Score = score;
            DatePlayed = DateTime.Now;
        }

        //-----------------------------------------------------------
    }
}
