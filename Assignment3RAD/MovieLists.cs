using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3RAD
{
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

        private void _initValues ()
        {
            this.movieCost.Add(1, 1.99);
            this.movieGenera.Add(1, "comedy");
            this.movieCost.Add(2, 1.99);
            this.movieGenera.Add(2, "Drama");
        }
    }
}
