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
       	    new MovieViewModel { Id = 1, Name = "HungerGame", Rating = "10", ReleaseYear = 2012, Genre = "Action/Science Fiction" },
            new MovieViewModel { Id = 2, Name = "Frozen", Rating = "9", ReleaseYear = 2019, Genre = "Children" },
            new MovieViewModel { Id = 3, Name = "The Childe", Rating = "8", ReleaseYear = 2023, Genre = "Drama" },
            new MovieViewModel { Id = 4, Name = "Heart Of Stone", Rating = "7", ReleaseYear = 2023, Genre = "Action" },
            new MovieViewModel { Id = 5, Name = "Saw X", Rating = "6", ReleaseYear = 2023, Genre = "Horror" },
            new MovieViewModel { Id = 6, Name = "Barbie", Rating = "5", ReleaseYear = 2023, Genre = "Comedy" },
            new MovieViewModel { Id = 7, Name = "Father Stu", Rating = "4", ReleaseYear = 2022, Genre = "Biography" },
            new MovieViewModel { Id = 8, Name = "Encanto", Rating = "8", ReleaseYear = 2020, Genre = "Children" },
            new MovieViewModel { Id = 9, Name = "The Little Mermaid", Rating = "6", ReleaseYear = 2023, Genre = "Romance" },
            new MovieViewModel { Id = 10, Name = "Haunted Mansion", Rating = "7", ReleaseYear = 2023, Genre = "Comedy" },
            new MovieViewModel { Id = 11, Name = "The Last Voyage of the Demeter", Rating = "8", ReleaseYear = 2023, Genre = "Science Fiction" },
            new MovieViewModel { Id = 12, Name = "Last Sentinel", Rating = "9", ReleaseYear = 2023, Genre = "Horror" },
            new MovieViewModel { Id = 13, Name = "Padre Pio", Rating = "10", ReleaseYear = 2023, Genre = "Biography" },
            new MovieViewModel { Id = 14, Name = "Shazam! Fury of the Gods", Rating = "9", ReleaseYear = 2023, Genre = "Action" },
            new MovieViewModel { Id = 15, Name = ""The Suicide Squad, Rating = "8", ReleaseYear = 2021, Genre = "Action" },
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

