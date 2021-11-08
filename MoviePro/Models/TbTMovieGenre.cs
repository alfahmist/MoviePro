using System;
using System.Collections.Generic;

namespace MoviePro.Models
{
    public partial class TbTMovieGenre
    {
        public int MovieGenreId { get; set; }
        public int? MovieId { get; set; }
        public int? GenreId { get; set; }

        public virtual TbMGenre Genre { get; set; }
        public virtual TbMMovie Movie { get; set; }
    }
}
