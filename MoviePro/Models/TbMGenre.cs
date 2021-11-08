using System;
using System.Collections.Generic;

namespace MoviePro.Models
{
    public partial class TbMGenre
    {
        public TbMGenre()
        {
            TbTMovieGenre = new HashSet<TbTMovieGenre>();
        }

        public int GenreId { get; set; }
        public string GenreName { get; set; }

        public virtual ICollection<TbTMovieGenre> TbTMovieGenre { get; set; }
    }
}
