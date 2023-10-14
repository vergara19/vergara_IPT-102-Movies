using System;
using BSIT3L_Movies.Models;
using Microsoft.AspNetCore.Mvc;

namespace BSIT3L_Movies.Controllers
{
	public class MoviesController : Controller
    {
        private List<MovieViewModel> _movies;
        public MoviesController()
		{
            // Sample movie data
            _movies = new List<MovieViewModel>
            {
        new MovieViewModel { Id = 1, Name = "HungerGame", Rating = "6", ReleaseYear = 2012, Genre = "Action/Science Fiction" },
        new MovieViewModel { Id = 2, Name = "Frozen", Rating = "5", ReleaseYear = 2019, Genre = "Animation" },
        new MovieViewModel { Id = 3, Name = "The Childe", Rating = "4", ReleaseYear = 2023, Genre = "Drama" },
            };
        }
        public ActionResult Random()
        {
            var movie = new MovieViewModel() { Name = "Avatar", Rating = "5" };
            return View(movie);
        }
        public ActionResult GetMovie(int id)
        {
            var movie = _movies.Find(m => m.Id == id);
            if (movie == null)
                return NotFound();
            return View(movie);

        }

    }
}

