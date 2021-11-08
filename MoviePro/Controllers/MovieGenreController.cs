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
    public class MovieGenreController : BaseController<TbTMovieGenre, MovieGenreRepository, int>
    {
        private readonly MovieGenreRepository movieGenreRepository;
        public MovieGenreController(MovieGenreRepository movieGenreRepository) : base(movieGenreRepository)
        {
            this.movieGenreRepository = movieGenreRepository;
        }
    }
}
