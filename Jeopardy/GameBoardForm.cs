using JeopardyGame;
using JeopardyGame.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace JeopardyGame
{
    public partial class GameBoardForm : Form
    {

        private int numPlayers;
        public List<Category> categories = new List<Category>();
        private List<Button> buttonList = new List<Button>();
        int count = 0;
        public GameBoardForm(int numPlayers)
        {
            InitializeComponent();

            categories = GetQuestions();

            //Set the category names on the gameboard
            cat0.Text = categories[0].Name;
            cat1.Text = categories[1].Name;
            cat2.Text = categories[2].Name;
            cat3.Text = categories[3].Name;
            cat4.Text = categories[4].Name;

            this.numPlayers = numPlayers;  

            foreach(Button buttons in Controls.OfType<Button>())
            {
                buttonList.Add(buttons);   
            }


            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    
                }
            }

            if(numPlayers == 1)
            {
               
                lblPlayerOne.Text = OptionsForm.players[0].Name;
            }

            if (numPlayers == 2) 
            {
                
                lblPlayerTwo.Visible = true;
                score1.Visible = true;

                lblPlayerOne.Text = OptionsForm.players[0].Name;
                lblPlayerTwo.Text = OptionsForm.players[1].Name;
            }
            if (numPlayers == 3)
            {
                lblPlayerTwo.Visible = true;
                score1.Visible = true;

                lblPlayerThree.Visible = true;
                score2.Visible = true;

                lblPlayerOne.Text = OptionsForm.players[0].Name;
                lblPlayerTwo.Text = OptionsForm.players[1].Name;
                lblPlayerThree.Text = OptionsForm.players[2].Name;
            }         

        }

        /// <summary>
        /// This is the event handler for all question buttons on the game board
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_Click(object sender, EventArgs e)
        {
            //Increment the game count
            count++;

            //Store the sender argument in a var and convert it to type Button to get the button's name
            var button = (Button)sender;

            //Get the category and amount from the button's name using the Substring method
            string category = button.Name.Substring(5, 1);
            string amount = button.Name.Substring(6, 3);
            
            //Set button text to empty, remove the event handler, and change cursor style back to default
            button.Text = "";
            button.Click -= bt_Click;
            button.Cursor = default;

            //Create a new instance of the AandQForm and pass in the category and amount
            using (AandQForm questions = new AandQForm(category, amount, categories))
            {
                questions.ShowDialog();

                //Get the player who answered and update their score
                UpdateScore(questions.getPlayer());
            }
                
           
        }

        /// <summary>
        /// Updates the player's score on the screen and determines if game is over
        /// </summary>
        /// <param name="person"></param>
        public void UpdateScore(int person)
        {
            string tester = "score" + person;
            var scoreField = this.Controls.Find(tester, true);
            scoreField[0].Text = OptionsForm.players[person].Score.ToString();

            //If the count is 25, the game is over
            //Display final scores/winner
            if(count == 25)
            {
                ResultsForm results = new ResultsForm();
                results.Show();
                this.Close();
            }
        }

        /// <summary>
        /// Gets the questions from the XML file
        /// </summary>
        /// <returns></returns>
        public List<Category> GetQuestions()
        {
            //Create a new instance of the XML Serializer class
            XMLSerializer ser = new XMLSerializer();

            //Variable to hold the path of the file
            string path = string.Empty;

            //Variables to hold the input and output 
            string xmlInputData = string.Empty;
            string xmlOutputData = string.Empty;

            path = Directory.GetCurrentDirectory() + @"\Jeopardy.xml";
            xmlInputData = File.ReadAllText(path);

            //Use the XML serializer to walk through the XML structure and assign
            //Each node to customer class properties
            Jeopardy jeopardy = ser.Deserialize<Jeopardy>(xmlInputData);

            return jeopardy.Category;

        }

        /// <summary>
        /// Display rules of the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btHelp_Click(object sender, EventArgs e)
        {
            string helpText = "Select a dollar amount under a category. \r\n" +
                "A question is displayed. Select which player is answering,\r\n" +
                "and then enter the answer to the question.\r\n" +
                "If the guess is correct, the player's score increases by the selected amount.\r\n" +
                "If the guess is wrong, the score decreases by that amount,\r\n" +
                "and another player has the chance to guess.\r\n" + 
                "The game ends when all questions have been answered.";

            MessageBox.Show(helpText);
        }
    }
}
