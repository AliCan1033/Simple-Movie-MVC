using System.Collections.Generic;

namespace movieapp.Models
{
    public class MovieCategory
    {
        public Movie Movie { get; set; }
        public IEnumerable<Movie> Movies { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}