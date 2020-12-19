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
    /// This class is for the AandQForm. It displays the selected question and answer from the XML file. Users select which player is answering and if their guess is correct.
    /// </summary>
    public partial class AandQForm : Form
    {
        /// <summary>
        /// Fields for the AandQForm class
        /// </summary>
        private string category;
        private string amount;
        int selectedPlayer = 0;
        private List<Category> jeopardy;
        private string answer;

        /// <summary>
        /// Constructor that takes in the selected category, amount, and the list of Jeopardy questions
        /// </summary>
        /// <param name="category"></param>
        /// <param name="amount"></param>
        /// <param name="jeopardy"></param>
        public AandQForm(string category, string amount, List<Category> jeopardy)
        {
            InitializeComponent();
            
            this.category = category;
            this.amount = amount;
            this.jeopardy = jeopardy;

            //Load the Select Which Player Is Anwering combobox using the list of players that was passed to the constructor
            for (int i = 0; i < OptionsForm.players.Count; i++)
            {
                cmBoxPlayers.Items.Add(OptionsForm.players[i].Name);
            }

            //Load "answer" that displays based on the dollar amount that was sent to the constructor
            switch (amount)
            {
                case "100":
                    lblAnswer.Text = jeopardy[Convert.ToInt32(category)].First.Text;
                    answer = jeopardy[Convert.ToInt32(category)].First.Answer;
                    break;
                case "200":
                    lblAnswer.Text = jeopardy[Convert.ToInt32(category)].Second.Text;
                    answer = jeopardy[Convert.ToInt32(category)].Second.Answer;
                    break;
                case "300":
                    lblAnswer.Text = jeopardy[Convert.ToInt32(category)].Third.Text;
                    answer = jeopardy[Convert.ToInt32(category)].Third.Answer;
                    break;
                case "400":
                    lblAnswer.Text = jeopardy[Convert.ToInt32(category)].Fourth.Text;
                    answer = jeopardy[Convert.ToInt32(category)].Fourth.Answer;
                    break;
                case "500":
                    lblAnswer.Text = jeopardy[Convert.ToInt32(category)].Fifth.Text;
                    answer = jeopardy[Convert.ToInt32(category)].Fifth.Answer;
                    break;
                default:
                    break;
            }
            


        }

        /// <summary>
        /// When players click Submit, fields are validated and a dialog box appears to collect was the player guess was correct or not. Player score is adjusted and form is then closed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSubmit_Click(object sender, EventArgs e)
        {

            //Ensure that a player is selected. If not,  display message and exit method
            if (cmBoxPlayers.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Please select a player");
                cmBoxPlayers.Focus();
            }

            //Ensure that a response is entered. If not, display message and exit method
            if(txtBxResponse.Text == "")
            {
                MessageBox.Show("Please enter a response");
                txtBxResponse.Focus();
            }

            //Show dialog box displaying correct message
            //Have user select if response was right or wrong
           DialogResult result = MessageBox.Show($"Correct answer: {answer} \r\n\r\nDid you answer correctly?", "Correct Answer", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                //Increase score
                OptionsForm.players[selectedPlayer].Score += Convert.ToInt32(amount);
                
                //Close form
                this.Close();
            }

            if(result == DialogResult.No)
            {
                //Decrease score
                OptionsForm.players[selectedPlayer].Score -= Convert.ToInt32(amount);
        
                //Close form
                this.Close();
            }
        
        }

        /// <summary>
        /// If users change which player is answering, update the selectedPlayer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmBoxPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPlayer = cmBoxPlayers.SelectedIndex;
           
        }

        /// <summary>
        /// Return the selectedPlayer for the GameBoardForm
        /// </summary>
        /// <returns></returns>
        public int getPlayer()
        {
            return selectedPlayer;
        }
    }
}
