using JeopardyGame.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeopardyGame
{
    /// <summary>
    /// This class is for the Results form and displays the current game results and past games
    /// </summary>
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();

            GetPastScores();

            DisplayScores();      

        }

        /// <summary>
        /// Displays winner and scores for the current game
        /// </summary>
        private void DisplayScores()
        {
            //Sort the players' scores in descending order
            var orderByScore = from scores in OptionsForm.players
                               orderby scores.Score descending
                               select scores;

            //Create a list from the sorted order
            var scoreList = orderByScore.ToList();

            //Get the current date so it can be added to the game object constructor
            DateTime currentDate = DateTime.Now;

            //Create a new game object using the current game info
            Game game = new Game(scoreList, scoreList[0].Name, scoreList[0].Score, currentDate);

            //Serialize the current game object and add to the database
            Serializer.SerializeNow(game);

            //Display the winner's name and score from the current game
            lblCurrentResults.Text = "Winner: " + scoreList[0].Name + " Score: " + scoreList[0].Score;

            //If more than one player, display each player's name, score, and place
            if (scoreList.Count > 1)
            {
                for (int i = 1; i < scoreList.Count; i++)
                {
                    lblCurrentResults.Text += "\r\n" +  "Place " + (i + 1) + ": " +
                        scoreList[i].Name +
                        " Score: " + scoreList[i].Score;
                }
            }

        }

        /// <summary>
        /// Gets and displays scores/winner from past games
        /// </summary>
        public void GetPastScores()
        {
            //Get all previous games from the database
            var gameResults = DataAdapter.GetGameResults();

            //Iterate through the past games and display info/results for each game
            foreach(var game in gameResults)
            {
                //Create a new row and populate the cells

                if(game.GamePlayers.Count == 1)
                {
                    gridGames.Rows.Add(game.GameDate, game.Winner, game.WinnerScore, "-", "-");
                }

                if(game.GamePlayers.Count == 2)
                {
                    gridGames.Rows.Add(game.GameDate, game.Winner, game.WinnerScore,
                        game.GamePlayers[1].Name + ": " +
                       game.GamePlayers[1].Score, "-");
                }

                if (game.GamePlayers.Count == 3)
                {
                    gridGames.Rows.Add(game.GameDate, game.Winner, game.WinnerScore,
                        game.GamePlayers[1].Name + ": " +
                       game.GamePlayers[1].Score,
                         game.GamePlayers[2].Name + ": " +
                       game.GamePlayers[2].Score);
                }

            }
        }

        /// <summary>
        /// Start a new game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNewGame_Click(object sender, EventArgs e)
        {
            OptionsForm optionsForm = new OptionsForm();
            optionsForm.Show();
            this.Close();
        }
    }
}
