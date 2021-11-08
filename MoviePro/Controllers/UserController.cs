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
    public class UserController : BaseController<TbMUser, UserRepository, int>
    {
        private readonly UserRepository userRepository;
        public UserController(UserRepository userRepository) : base(userRepository)
        {
            this.userRepository = userRepository;
        }
    }
}
