using System;
using System.Collections.Generic;

namespace MoviePro.Models
{
    public partial class TbMMovie
    {
        public TbMMovie()
        {
            TbTMovieGenre = new HashSet<TbTMovieGenre>();
            TbTUserMovie = new HashSet<TbTUserMovie>();
        }

        public int MovieId { get; set; }
        public DateTime? DateRelease { get; set; }
        public int? Duration { get; set; }
        public string Overview { get; set; }
        public string Title { get; set; }

        public virtual ICollection<TbTMovieGenre> TbTMovieGenre { get; set; }
        public virtual ICollection<TbTUserMovie> TbTUserMovie { get; set; }
    }
}
