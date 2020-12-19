using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeopardyGame.Classes
{
    /// <summary>
    /// Class for storing players each game. Serializable badge is used so player objects can be serialized before adding to the database
    /// </summary>
    [Serializable]
    public class Player
    {
        /// <summary>
        /// Private fields for the Player class
        /// </summary>
        private int score;
        private string name;

        /// <summary>
        /// Constructor for the Player class
        /// </summary>
        /// <param name="score"></param>
        /// <param name="name"></param>
        public Player(int score, string name)
        {
            this.Score = score;
            this.Name = name;
        }

        /// <summary>
        /// Public properties for the Player class
        /// </summary>
        public int Score { get => score; set => score = value; }
        public string Name { get => name; set => name = value; }
    }
}
