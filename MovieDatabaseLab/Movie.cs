using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabaseLab
{
    public class Movie
    {
        public string Title { get; set; }
        public string Category { get; set; }

        public Movie(string filmTitle, string filmCategory)
        {
            Title = filmTitle;
            Category = filmCategory;
        }
    }
}
