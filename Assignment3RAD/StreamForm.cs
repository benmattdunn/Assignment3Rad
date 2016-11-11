using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3RAD
{
    public partial class StreamForm : Form
    {

        private string _displayInfoMain = "Thank you for choosing movie Banzai!";
        private string _displayInfoMovieOne = "Your movie Selection of ";
        private string _displayInfoMovieTwo = " will begin shortly.";
        private string _displayCostInfo = "Your credit card has been charged ";
        public StreamForm(double cost, string movieTitle)
        {
            InitializeComponent();
            this.TitleMessagelabel.Text = this._displayInfoMain;
            this.ChargeLabel.Text = this._displayCostInfo + cost.ToString("C2");
            this.MovieLabel.Text = this._displayInfoMovieOne + movieTitle + this._displayInfoMovieTwo;

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }
    }
}
