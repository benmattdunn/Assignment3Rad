using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3RAD
{
    /// <summary>
    /// item to carry all the information related
    /// to the movie from the class. 
    /// </summary>
    public class MovieLists
    {
        public string selectedMovie { get; set; }
        public Dictionary<string, MovieReferenceClass> movies { get; set; }
        public Dictionary<int,string> movieGenera { get; set; }
        public Dictionary<int, double> movieCost { get; set; }

        public MovieLists()
        {
            this.movies = new Dictionary<string, MovieReferenceClass>();
            this.movieCost = new Dictionary<int, double>();
            this.movieGenera = new Dictionary<int, string>();
            _initValues(); 
        }
        /// <summary>
        /// Initialized the moviecost and moviegenera dictionaries. I would of
        /// prefered to use a more robust method for getting the types such
        /// as a referenced table of some sort to make this a server side
        /// application, however in this case it's okay. 
        /// </summary>
        private void _initValues ()
        {
            this.movieCost.Add(1, 1.99);
            this.movieGenera.Add(1, "Comedy");
            this.movieCost.Add(2, 1.99);
            this.movieGenera.Add(2, "Drama");
            this.movieCost.Add(3, 2.99);
            this.movieGenera.Add(3, "Action");
            this.movieCost.Add(4, 2.99);
            this.movieGenera.Add(4, "Sci-Fi");
            this.movieCost.Add(5, 2.99);
            this.movieGenera.Add(5, "Horror");
            this.movieCost.Add(6, 1.99);
            this.movieGenera.Add(6, "Thriller");
            this.movieCost.Add(7, 0.99);
            this.movieGenera.Add(7, "Family");
            this.movieCost.Add(8, 4.99);
            this.movieGenera.Add(8, "New Release");
            this.movieCost.Add(9, 10.00);
            this.movieGenera.Add(9, "A love story");


        }
    }
}
