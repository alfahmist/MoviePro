using MoviePro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro.Repositories.Data
{
    public class UserMovieRepository : GenericRepository<TbTUserMovie, MovieDBContext, int>
    {
        private readonly MovieDBContext myContext;

        public UserMovieRepository(MovieDBContext myContext) : base(myContext)
        {

        }
    }
}
