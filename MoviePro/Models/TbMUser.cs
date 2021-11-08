using System;
using System.Collections.Generic;

namespace MoviePro.Models
{
    public partial class TbMUser
    {
        public TbMUser()
        {
            TbTUserMovie = new HashSet<TbTUserMovie>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<TbTUserMovie> TbTUserMovie { get; set; }
    }
}
