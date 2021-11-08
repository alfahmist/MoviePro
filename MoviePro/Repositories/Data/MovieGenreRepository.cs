using MoviePro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro.Repositories.Data
{
    public class MovieGenreRepository : GenericRepository<TbTMovieGenre, MovieDBContext, int>
    {
        private readonly MovieDBContext myContext;

        public MovieGenreRepository(MovieDBContext myContext) : base(myContext)
        {

        }
    }
}
