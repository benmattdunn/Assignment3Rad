using Assignment3RAD.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                //_movielist.movies.Add("Avengers", new MovieReferenceClass("Avengers", 2, null));
                _movielist.movies.Add("Ceder Rapids", new MovieReferenceClass("Ceader Rapids", 1, new Bitmap((Bitmap)Resources.cedarRapids)));
                _movielist.movies.Add("Death Race Two", new MovieReferenceClass("Death Race Two", 2, (Bitmap)Resources.deathRaceTwo));
                _movielist.movies.Add("Gnomeo And Juilet", new MovieReferenceClass("Gnomeo And Juilet", 1, (Bitmap)Resources.gnomeoAndJulet));
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
