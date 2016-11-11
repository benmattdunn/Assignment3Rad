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
    public partial class SelectionForm : Form
    {
        public SelectionForm()
        {
            InitializeComponent();
            _ImportLists();
        }
    

    /// <summary>
    /// imports the list into the list object and adds their key to the selection box
    /// </summary>
    private void _ImportLists() {
            object[] temp = new object[Program._movielist.movies.Count];
            for (int k = 0 ; k < Program._movielist.movies.Count; k++)
            {
                temp[k] = Program._movielist.movies.ElementAt(k).Key;
                //MessageBox.Show(Program._movielist.movies.ElementAt(k).Key); debug, check each item as it loads.
            }
            this.MovieSelectionListBox.Items.AddRange(temp);
            this.MovieSelectionListBox.Sorted = true; //order the items after adding them. 
        }

        private void YourSelectionInfoTableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm._previousForm = this;
            this.Hide();
            orderForm.Show(); 
        }


        /// <summary>
        /// listens for a change in the selection box and updates apropriately. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MovieSelectionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            //listBox1.GetItemText(listBox1.SelectedItem)


            if (Program._movielist.movies.ContainsKey(this.MovieSelectionListBox.GetItemText(MovieSelectionListBox.SelectedItem)))
            {
                //MessageBox.Show(this.MovieSelectionListBox.GetItemText(MovieSelectionListBox.SelectedItem));

                MovieReferenceClass temp = new MovieReferenceClass();
                temp = Program._movielist.movies[this.MovieSelectionListBox.GetItemText(MovieSelectionListBox.SelectedItem)];
                this.GroupSelectionMoviePictureBox.BackgroundImage = temp._image;
                this.MovieTextBox.Text = temp._name;
                this.GeneraTextBox.Text = Program._movielist.movieGenera[temp._type];
                Program._movielist.selectedMovie = this.MovieSelectionListBox.GetItemText(MovieSelectionListBox.SelectedItem);
                
                //this.GroupSelectionMoviePictureBox.BackgroundImage = temp.
            }

                
        }
    }
}
