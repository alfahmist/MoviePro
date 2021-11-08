using MoviePro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro.Repositories.Data
{
    public class UserRepository : GenericRepository<TbMUser, MovieDBContext, int>
    {
        private readonly MovieDBContext myContext;

        public UserRepository(MovieDBContext myContext) : base(myContext)
        {

        }
    }
}
