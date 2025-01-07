using Microsoft.AspNetCore.Mvc;
using ratingMovie.Models;

namespace ratingMovie.Controllers;

[ApiController]
[Route("[controller]")]
public class MovieController : ControllerBase
{
    public static List<Movie>? movies = new List<Movie>();
    [HttpPost]
    public void AddMovie([FromBody] params Movie[]? _movie)
    {
        foreach (var movie in _movie!)
        {
            if (movies!.Contains(movie) == false)
            {
                Console.WriteLine(movie.Name);
                movie.Id = movies.Count + 1;
                movies!.Add(movie);
            }

        }
    }

    [HttpGet]
    public IEnumerable<Movie> GetMovie([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        return movies!.Skip(skip).Take(take);
    }
}