using System;
using System.Collections.Generic;

namespace MoviePro.Models
{
    public partial class TbTUserMovie
    {
        public int? UserMovieId { get; set; }
        public int? UserId { get; set; }
        public int? MovieId { get; set; }
        public int? Rating { get; set; }

        public virtual TbMMovie Movie { get; set; }
        public virtual TbMUser User { get; set; }
    }
}
