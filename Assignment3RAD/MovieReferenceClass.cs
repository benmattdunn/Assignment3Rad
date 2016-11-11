using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Created by Ben M. Dunn 
/// Student #100098171
/// Final Version 11, novemeber 2016
/// 
/// class that holds the required movie information for a single
/// movie.
/// </summary>
namespace Assignment3RAD
{

    /// <summary>
    /// simple movie class to allow an array of held values to be created 
    /// </summary>
    public class MovieReferenceClass
    {
        public string _name { get; }
        public int _type { get; }
        public Bitmap _image { get; }



        public MovieReferenceClass()
        {

        }
        public MovieReferenceClass (string name, int type, Bitmap image)
        {
            this._name = name;
            this._type = type;
            this._image = image;
        }

        public MovieReferenceClass(MovieReferenceClass reference)
        {
            this._image = reference._image;
            this._type = reference._type;
            this._name = reference._name;
        }
       


    }
}
