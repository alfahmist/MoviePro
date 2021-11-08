using MoviePro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro.Repositories.Data
{
    public class GenreRepository : GenericRepository<TbMGenre, MovieDBContext, int>
    {
        private readonly MovieDBContext myContext;

        public GenreRepository(MovieDBContext myContext) : base(myContext)
        {

        }
    }
}
