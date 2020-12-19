using JeopardyGame.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeopardyGame
{
    /// <summary>
    /// This class is for the OptionsForm. It is the first form that appears and collects how many players are playing and their names.
    /// </summary>
    public partial class OptionsForm : Form
    {
        //Create an instance variable to hold the splash form
        private SplashForm myform;
        private GameBoardForm gameBoard;
        private int numPlayers;
        public static List<Player> players = new List<Player>();

        /// <summary>
        /// Constructor that starts the splash screen
        /// </summary>
        public OptionsForm()
        {
            InitializeComponent();

            //Reset the list of players
            players.Clear();

            //In this constructor, create a separate thread so the main form will now lock up 
            //while the splash screen is running
            ParameterizedThreadStart pts = new ParameterizedThreadStart(DoSplash);
            Thread t = new Thread(pts);
            double time = 0.05d;
            t.Start(time);
        }

        /// <summary>
        /// This method creates the splash screen form and shows it on the screen
        /// </summary>
        /// <param name="o"></param>
        private void DoSplash(object o)
        {
            double value = (double)o;
            myform = new SplashForm();
            myform.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                //Give compiler some busy work
                System.Diagnostics.Debug.WriteLine(i.ToString());
            }

            //Raise the event handler for the Close button
            myform.MakeCloseButtonVisible();
        }

        /// <summary>
        /// When Go is clicked, first validate fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btGo_Click(object sender, EventArgs e)
        {
            switch(numPlayers)
            {
                case 1:
                    if (txtBxPlayer1.Text == "")
                    {
                        MessageBox.Show("Please enter Player 1 Name");
                        txtBxPlayer1.Focus();
                    }
                    else
                    {

                        Player player1 = new Player(0, txtBxPlayer1.Text);
                        players.Add(player1);
                        DisplayGameBoard(1);

                    }
                    break;
                case 2:
                    if (txtBxPlayer1.Text == "") 
                        MessageBox.Show("Please enter Player 1 Name");
                    else if (txtBxPlayer2.Text == "") 
                        MessageBox.Show("Please enter Player 2 Name");
                    else
                    {
                        Player player1 = new Player(0, txtBxPlayer1.Text);
                        Player player2 = new Player(0, txtBxPlayer2.Text);

                        players.Add(player1);
                        players.Add(player2);
                        DisplayGameBoard(2);
                    }
                    break;
                case 3:
                    if (txtBxPlayer1.Text == "")
                        MessageBox.Show("Please enter Player 1 Name");
                    else if (txtBxPlayer2.Text == "")
                        MessageBox.Show("Please enter Player 2 Name");
                    else if (txtBxPlayer3.Text == "")
                        MessageBox.Show("Please enter Player 3 Name");
                    else
                    {
                        Player player1 = new Player(0, txtBxPlayer1.Text);
                        Player player2 = new Player(0, txtBxPlayer2.Text);
                        Player player3 = new Player(0, txtBxPlayer3.Text);

                        players.Add(player1);
                        players.Add(player2);
                        players.Add(player3);
                        DisplayGameBoard(3);
                    }
                    break;
                default:
                    MessageBox.Show("Please select the Number of Players");
                    break;
            }
        }

        /// <summary>
        /// Display the gameboard
        /// </summary>
        /// <param name="number"></param>
        private void DisplayGameBoard(int number)
        {
            //Hide the current form
            this.Hide();

            //Create a new instance of the GameBoardForm and pass in the number
            gameBoard = new GameBoardForm(number);
            gameBoard.Show();
        }

        /// <summary>
        /// If user changes the number of players, update how many Name fields display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmBxNumPlayers.SelectedItem.ToString() == "1")
            {
                //Ensure player 2 label and field are not visible
                lblPlayerTwo.Visible = false;
                txtBxPlayer2.Visible = false;

                //Ensure player 3 label and field are not visible
                lblPlayerThree.Visible = false;
                txtBxPlayer3.Visible = false;

                //Set numPlayers variable
                numPlayers = 1;
            }

            else if (cmBxNumPlayers.SelectedItem.ToString() == "2") 
            {
                //Make player 2 label and field visible
                lblPlayerTwo.Visible = true;
                txtBxPlayer2.Visible = true;

                //Ensure player 3 label and field are not visible
                lblPlayerThree.Visible = false;
                txtBxPlayer3.Visible = false;

                //Set numPlayers variable
                numPlayers = 2;
            }

            else if (cmBxNumPlayers.SelectedItem.ToString() == "3")
            {
                lblPlayerTwo.Visible = true;
                txtBxPlayer2.Visible = true;

                lblPlayerThree.Visible = true;
                txtBxPlayer3.Visible = true;

                numPlayers = 3;
            }

        }
    }
}
