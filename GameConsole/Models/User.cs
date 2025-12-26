using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Models
{
    internal class User
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public List<HighScore> HighScores { get; set; } = new List<HighScore>();
        public List<GameHistory> GameHistory { get; set; } = new List<GameHistory>();

        //-----------------------------------------------------------

        public User(string name, string userName, string password)
        {
            Name = name;
            UserName = userName;
            Password = password;
            HighScores = new List<HighScore>();
        }
    }
}
