using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Created by Ben M. Dunn 
/// Student #100098171
/// Final Version 11, novemeber 2016
/// 
/// simple splash screen for user control and loading. 
/// waits three seconds then loads up the next form. 
/// </summary>
namespace Assignment3RAD
{
    public partial class SplashScreen : Form
    {

        private int _timerCount = 0; 
        public SplashScreen()
        {
            InitializeComponent();
            this.SplashScreenTimer.Start();
        }

        /// <summary>
        /// because the timer is set at 1 milisecond, and this is just for show, there
        /// is a range of 3000 on the progress bar and a total elipsed program time of 
        /// 3010 seconds before the program boots. If this was a real load method
        /// I would pass out the values from the total load time as a percent of the 
        /// program loaded and update through the bar though a actual "show progess",
        /// methods rather then this simple load display. (also I would not use 1 
        /// mili as the timing period as that's just a waste of CPU processing power). 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //updated progress bar and updates display to render the proccessing time
            
            this._timerCount += 1;
            if (this._timerCount == 360)
            {
                //MessageBox.Show("reached");
                this.Hide();
                SelectionForm selectionForm = new SelectionForm();
                selectionForm.Show();
                //this.Close();
                
                this.SplashScreenTimer.Stop(); //stop the timer
                this.SplashScreenTimer.Dispose(); //clear the timer. 
            }
            else
            {
                this.SplashScreenProgressBar.Increment(1);
            }
        }
    }
}
