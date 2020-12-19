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
    /// This class is for the splash form that first appears when the game is launched initially
    /// </summary>
    public partial class SplashForm : Form
    {
        private int counter;
        public event MakeCloseButtonVisibleDelegate MCBVEvent;

        public delegate void MakeCloseButtonVisibleDelegate();

        public SplashForm()
        {
            InitializeComponent();

            //Connect the event handler to the delegate
            MCBVEvent += MakeCloseButtonVisible;

            //Start the first timer
            timer1.Start();
        }


        /// <summary>
        /// This method allows us to show the close button in case the animation timer fails to close
        /// the form as designed. Use the Invoke flag to check if we are calling from another thread
        /// so we have permission to change the button.
        /// </summary>
        public void MakeCloseButtonVisible()
        {
            if (InvokeRequired)
            {
                Invoke(MCBVEvent);
            }
            else
            {
                btClose.Visible = true;
            }
        }

        /// <summary>
        /// This method fires with every tick and changes the opacity of the form as it loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //adjust the opacity
            this.Opacity += 0.05d;

            if (this.Opacity <= 1)
            {
                //Stop the timer
                timer1.Stop();

                //Start the third timer
                timer3.Start();
            }
        }

        /// <summary>
        /// This method fires with every tick of the second timer and controls the exit animation of the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.05d;
            this.Width -= 30;
            this.Height -= 18;
            this.Left -= 15;
            this.Top -= 9;

            //When we get to a pointi that the form is small and too opaque we should close it
            if (this.Opacity < 0.000001d)
            {
                timer2.Stop();
                this.Close();
            }
        }

        /// <summary>
        /// This method fires with every tick of the timer and controls how long the splash form hangs out
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer3_Tick(object sender, EventArgs e)
        {
            //How fast do you want to go
            counter += 100;

            //How long do you want to wait
            if (counter <= 4000)
            {
                timer3.Stop();

                //Start the second timer that controls the exit
                timer2.Start();
            }
        }

        /// <summary>
        /// Gives users the option to manually close the splash screen window in case it does not automatically close by itself
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btClose_Click(object sender, EventArgs e)
        {
            //Start the second timer so the form does the animation and closes
            timer2.Start();
        }
    }
}
