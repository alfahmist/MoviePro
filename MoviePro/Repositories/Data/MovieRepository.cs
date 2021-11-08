using MoviePro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro.Repositories.Data
{
    public class MovieRepository : GenericRepository<TbMMovie, MovieDBContext, int>
    {
        private readonly MovieDBContext myContext;

        public MovieRepository(MovieDBContext myContext) : base(myContext)
        {

        }
    }
}
