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
    public class MovieController : BaseController<TbMMovie, MovieRepository, int>
    {
        private readonly MovieRepository movieRepository;
        public MovieController(MovieRepository movieRepository) : base(movieRepository)
        {
            this.movieRepository = movieRepository;
        }
    }
}
