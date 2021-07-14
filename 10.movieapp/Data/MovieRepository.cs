using System.Collections.Generic;
using System.Linq;
using movieapp.Models;

namespace movieapp.Data
{
    public static class MovieRepository
    {
        private static List<Movie> _movies =null;

        static MovieRepository()
        {
            _movies =new List<Movie>()
            {
                new Movie {Id=1,Name="Shazam",ShortDescription="Shazam",Description="Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorem, iusto consequatur!",ImageUrl="1.jpg",CategoryId=1},
                new Movie {Id=2,Name="Amazing Grace",ShortDescription="Amazing Grace",Description="Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorem, iusto consequatur!",ImageUrl="2.jpg",CategoryId=2},
                new Movie {Id=3,Name="High Life",ShortDescription="High Life",Description="Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorem, iusto consequatur!",ImageUrl="3.jpg",CategoryId=2},
                new Movie {Id=4,Name="Bilboard",ShortDescription="Bilboard",Description="Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorem, iusto consequatur!",ImageUrl="4.jpg",CategoryId=3},
                new Movie {Id=5,Name="Storm Boy",ShortDescription="Storm Boy",Description="Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorem, iusto consequatur!",ImageUrl="5.jpg",CategoryId=3}
            };
        }
        public static List<Movie> Movies 
        {
            get{
                return _movies;
            }
        }
        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);
        }
        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(i=>i.Id==id);
        }
    }
}