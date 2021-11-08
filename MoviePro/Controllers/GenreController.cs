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
    public class GenreController : BaseController<TbMGenre, GenreRepository, int>
    {
        private readonly GenreRepository genreRepository;
        public GenreController(GenreRepository genreRepository) : base(genreRepository)
        {
            this.genreRepository = genreRepository;
        }
    }
}
