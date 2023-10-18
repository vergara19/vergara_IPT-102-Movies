using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BSIT3L_Movies.Models;
using System.Collections.Generic;

namespace BSIT3L_Movies.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly List<MovieViewModel> _movies;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
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
            new MovieViewModel { Id = 15, Name = ""The Suicide Squad, Rating = "8", ReleaseYear = 2021, Genre = "Action" }
        };
    }

    public IActionResult Index()
    {
        return View(_movies);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

