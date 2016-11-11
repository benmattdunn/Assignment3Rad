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

namespace Assignment3RAD
{
    public partial class OrderForm : Form
    {
        private readonly double _movieBuyCost = 10.00;
        private readonly double _tax = 0.13;
        
        private double _movieCost;
        private double _subTotal;
        private double _totalTaxCharge;
        private double _totalCharge;

        private Thread _movieCostCalculator;
        private bool _running = true;

        /// <summary>
        /// Initalizes the order form and it's components, values and threads.
        /// </summary>
        public OrderForm()
        {
            InitializeComponent();
            _initalizeValues();
            _startThreads(); 
        }

        /// <summary>
        /// Starts the core values and the current scope of the program. 
        /// </summary>
        private void _initalizeValues ()
        {
            MovieReferenceClass temp = new MovieReferenceClass();
            temp = Program._movielist.movies[Program._movielist.selectedMovie];
            this.MoviePictureBox.BackgroundImage = temp._image;
            this.MovieTitleTextBox.Text = temp._name;
            this.CatagoryTextBox.Text = Program._movielist.movieGenera[temp._type];
            //this.CostTextBox.Text = Program._movielist.movieCost[temp._type].ToString("C2");
        }

        /// <summary>
        /// starts the control thread for the updates to values. 
        /// </summary>
        private void _startThreads()
        {

            this._movieCostCalculator = new Thread(
                new ThreadStart(this._updateCosts));
            this._movieCostCalculator.Start();
        }

        /// <summary>
        /// Control method for the update thread. 
        /// </summary>
        private void _updateCosts()
        {
            do
            {
                this._setText(Program._movielist.movieCost[
                    Program._movielist.movies[Program._movielist.selectedMovie]
                    ._type].ToString("C2"), this.CostTextBox); //updates the 
                //get the type and the cost of the type. 
                this._movieCost = Program._movielist.movieCost[
                    Program._movielist.movies[Program._movielist.selectedMovie]._type];

                if (this.OwnMovieCheckBox.Checked == true)
                {
                    this._subTotal = this._movieCost + this._movieBuyCost;
                }   
                else
                {
                    this._subTotal = this._movieCost;
                }
                //update the internal values and display as changes are made, only done for
                // the check box. 
                this._setText(this._subTotal.ToString("C2"), this.SubTotalTextBox);
                this._totalTaxCharge = this._subTotal * this._tax;
                this._setText(this._totalTaxCharge.ToString("C2"), this.SalesTaxTextBox);
                this._totalCharge = this._totalTaxCharge + this._subTotal;
                this._setText(this._totalCharge.ToString("C2"), this.GrandTotalTextBox);

                
                Thread.Sleep(10);
            } while (this._running);
        }

        /// <summary>
        /// returns to the previous form and closes this form. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            this._previousForm.Show();
            this.Dispose();
            this.Close();
        }

        /// <summary>
        /// Event for exiting the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this._exitProgram();
        }

        /// <summary>
        /// Takes a control and allows the generic update of the control via a thread or an outside 
        /// class. Allows the invoke of a new action aimed at the control of the text field.
        /// this class may be made more generic later on. Used a lambda to invoke a new
        /// action on the object (control). Added to the form to allow easy outside access of methods
        /// and display. However, set to private for the time being as I would want to validate this
        /// with another method if I made it public. 
        /// 
        /// old method copied from assignment 1. 
        /// </summary>
        /// <param name="text">a text parrameter</param>
        /// <param name="control">Referenced control</param>
        private void _setText(string text, Control control)
        {
            if (control.InvokeRequired)
                control.Invoke(new Action(() => control.Text = text));
            else
                control.Text = text;
        }




        /// <summary>
        /// gracefully exits the program. 
        /// </summary>
        private void _exitProgram()
        {
            this._previousForm.Dispose();
            this._previousForm.Close();
            this.Dispose();
            this.Close();
            Application.Exit();
        }

        /// <summary>
        /// Closes the primary two forms and moves the user to the final form with the information.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StreamClick(object sender, EventArgs e)
        {
            StreamForm streamForm = new StreamForm(this._totalCharge, Program._movielist.selectedMovie);
            streamForm.Show();
            // as their is no required back feature, close the current form and take the user 
            // to the final billing page.
            this._previousForm.Dispose();
            this.Dispose();
        }
    }
}
