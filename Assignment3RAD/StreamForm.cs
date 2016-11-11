using Assignment3RAD.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Created by Ben M. Dunn 
/// Student #100098171
/// Final Version 11, novemeber 2016
/// 
/// displays the final form and the required information. Has 
/// a easter egg because I was bored. 
/// ...I apologize for nothing.
/// </summary>
namespace Assignment3RAD
{
    public partial class StreamForm : Form
    {
        private string _movieTitle;
        private System.Media.SoundPlayer soundplayer;

        private string _displayInfoMain = "Thank you for choosing movie Banzai!";
        private string _displayInfoMovieOne = "Your movie Selection of ";
        private string _displayInfoMovieTwo = " will begin shortly.";
        private string _displayCostInfo = "Your credit card has been charged ";
        public StreamForm(double cost, string movieTitle)
        {
            // what I was supposed to do. 
            this._movieTitle = movieTitle;
            InitializeComponent();
            this.TitleMessagelabel.Text = this._displayInfoMain;
            this.ChargeLabel.Text = this._displayCostInfo + cost.ToString("C2");
            this.MovieLabel.Text = this._displayInfoMovieOne + movieTitle + this._displayInfoMovieTwo;
            if (movieTitle.Equals("DeadPool"))
            {
                //what I decided to do.
                
                this.MessageLayoutPanel.Visible = false;
                this.Width = Resources.deadpool_ver13.Width + 10;
                this.Height = Resources.deadpool_ver13.Height + 10;
                this.BackgroundImage = Resources.deadpool_ver13;
                //and just for the shits and giggles of it.
                Stream StreamSound = Resources.someSoundFile;
                soundplayer = new System.Media.SoundPlayer(StreamSound);
                soundplayer.Play();
                // really done cause I wanted to see how C# handles sound files internally, but still fun.
            }

        }
        /// <summary>
        /// closes the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        /// <summary>
        /// if the easter egg is activated, closes the program
        /// after a message from our sponsers.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this._movieTitle.Equals("DeadPool"))
            {
                this.Dispose();
                Application.Exit();
            }
        }
    }
}
