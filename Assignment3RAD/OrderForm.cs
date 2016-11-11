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
    public partial class OrderForm : Form
    {
        private readonly double _movieBuyCost = 10.00;
        private readonly double _tax = 1.13;
        private double _movieCost;
        private double _totalCharge;
        private thread


        public OrderForm()
        {
            InitializeComponent();
            _initalizeValues();
        }

        private void _initalizeValues ()
        {
            MovieReferenceClass temp = new MovieReferenceClass();
            temp = Program._movielist.movies[Program._movielist.selectedMovie];
            this.MoviePictureBox.BackgroundImage = temp._image;
            this.MovieTitleTextBox.Text = temp._name;
            this.CatagoryTextBox.Text = Program._movielist.movieGenera[temp._type];
            this.CostTextBox.Text = Program._movielist.movieCost[temp._type].ToString("C2");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this._previousForm.Show(); 
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this._exitProgram();
        }





        private void _exitProgram()
        {
            this._previousForm.Dispose();
            this._previousForm.Close();
            this.Dispose();
            this.Close();
            Application.Exit();
        }
    }
}
