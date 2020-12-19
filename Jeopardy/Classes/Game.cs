using JeopardyGame.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeopardyGame.Classes
{
    /// <summary>
    /// This class holds information from each game. Serializable badge is used so Game objects can be serialized before adding to the database
    /// </summary>
    [Serializable]
    class Game
    {
        /// <summary>
        /// Private fields for the Game class
        /// </summary>
        private List<Player> gamePlayers;
        private string winner;
        private int winnerScore;
        DateTime gameDate;

        /// <summary>
        /// Constructor for the Game class
        /// </summary>
        /// <param name="gamePlayers"></param>
        /// <param name="winner"></param>
        /// <param name="winnerScore"></param>
        /// <param name="gameDate"></param>
        public Game(List<Player> gamePlayers, string winner, int winnerScore, DateTime gameDate)
        {
            this.gamePlayers = gamePlayers;
            this.winner = winner;
            this.winnerScore = winnerScore;
            this.gameDate = gameDate;
        }

        /// <summary>
        /// Public properties of the Game class
        /// </summary>
        public List<Player> GamePlayers { get => gamePlayers; set => gamePlayers = value; }
        public string Winner { get => winner; set => winner = value; }
        public int WinnerScore { get => winnerScore; set => winnerScore = value; }
        public DateTime GameDate { get => gameDate; set => gameDate = value; }
    }
}
