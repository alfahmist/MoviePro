using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviePro.Models;
using MoviePro.Repositories.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserMovieController : BaseController<TbTUserMovie, UserMovieRepository, int>
    {
        private readonly UserMovieRepository userMovieRepository;
        public UserMovieController(UserMovieRepository userMovieRepository) : base(userMovieRepository)
        {
            this.userMovieRepository = userMovieRepository;
        }
    }
}
