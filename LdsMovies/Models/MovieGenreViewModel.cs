using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace LdsMovies.Models
{
	public class MovieGenreViewModel
	{
		public List<Movie> Movies;
		public SelectList Genres;
        public SelectList SortOptions;
		public string MovieGenre { get; set; }
		public string SearchString { get; set; }
        public string MovieSort { get; set; }
	}
}