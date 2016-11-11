using Assignment3RAD.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Threading.Tasks;
using System.Windows.Forms;


/// <summary>
/// Created by Ben M. Dunn 
/// Student #100098171
/// Final Version 11, novemeber 2016
/// 
/// 
/// </summary>

namespace Assignment3RAD
{
    
    static class Program
    {
        public static MovieLists _movielist;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            _movielist = new MovieLists(); //initialize movie list. 


            //MovieReferenceClass test = new MovieReferenceClass("Ceader Rapids", 2, new Bitmap((Bitmap)Resources.cedarRapids));
            //_movielist.movies.Add("test", test);
            //catch for objects not being reference correctly, developement, but left in for good pratice.
            try
            {
                _movielist.movies.Add("Avengers", new MovieReferenceClass("Avengers", 3, new Bitmap((Bitmap)Resources.avengers)));
                _movielist.movies.Add("Ceder Rapids", new MovieReferenceClass("Ceader Rapids", 1, new Bitmap((Bitmap)Resources.cedarRapids)));
                _movielist.movies.Add("Death Race Two", new MovieReferenceClass("Death Race Two", 3, (Bitmap)Resources.deathRaceTwo));
                _movielist.movies.Add("Gnomeo And Juilet", new MovieReferenceClass("Gnomeo And Juilet", 5, (Bitmap)Resources.gnomeoAndJulet));
                _movielist.movies.Add("I Am Four", new MovieReferenceClass("I Am Four", 4, (Bitmap)Resources.IAmFour));
                _movielist.movies.Add("Just Go With It", new MovieReferenceClass("Just Go With It", 1, (Bitmap)Resources.justGoWithIt));
                _movielist.movies.Add("No Strings Attached", new MovieReferenceClass("No Strings Attached", 1, (Bitmap)Resources.noStringsAttached));
                _movielist.movies.Add("Real Steal", new MovieReferenceClass("Real Steal", 8, (Bitmap)Resources.realSteal));
                _movielist.movies.Add("Santum", new MovieReferenceClass("Santum", 3, (Bitmap)Resources.santum));
                _movielist.movies.Add("Season Of the Witch", new MovieReferenceClass("Season Of the Witch", 4, (Bitmap)Resources.seasonOfTheWitch));
                _movielist.movies.Add("The Company Men", new MovieReferenceClass("The Company Men", 2, (Bitmap)Resources.theCompanyMen));
                _movielist.movies.Add("The Delema", new MovieReferenceClass("The Delema", 1, (Bitmap)Resources.theDelema));
                _movielist.movies.Add("The Eagle", new MovieReferenceClass("The Eagle", 3, (Bitmap)Resources.theEagle));
                _movielist.movies.Add("The Mechanic", new MovieReferenceClass("The Mechanic", 3, (Bitmap)Resources.theMechanic));
                _movielist.movies.Add("The Other Woman", new MovieReferenceClass("The Other Woman", 3, (Bitmap)Resources.theOtherWoman));
                _movielist.movies.Add("The Rite", new MovieReferenceClass("The Rite", 5, (Bitmap)Resources.therite));
                _movielist.movies.Add("The Roommate", new MovieReferenceClass("The Roommate", 6, (Bitmap)Resources.theRoommate));
                _movielist.movies.Add("The Way Back", new MovieReferenceClass("The Way Back", 2, (Bitmap)Resources.theWayBack));
                _movielist.movies.Add("Waiting Forever", new MovieReferenceClass("Waiting Forever", 2, (Bitmap)Resources.waitingForever));
                _movielist.movies.Add("One Sheet", new MovieReferenceClass("One Sheet", 1, (Bitmap)Resources.onesheet));
                _movielist.movies.Add("DeadPool", new MovieReferenceClass("DeadPool", 9, (Bitmap)Resources.DeadPool));

            } catch (Exception e)
            {
                MessageBox.Show(e.TargetSite.Name);
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashScreen());
        }
    }
}
