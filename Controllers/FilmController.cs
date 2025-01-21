using Microsoft.AspNetCore.Mvc;
using ratingMovie.Models;
using ratingMovie.DATA;
using ratingMovie.DATA.Dto;
using AutoMapper;
using Microsoft.AspNetCore.Cors;

namespace ratingMovie.Controllers;

[ApiController]
[Route("[controller]")]
public class MovieController : ControllerBase
{
    private DataMovie _context;
    private IMapper _mapper;
    public MovieController(DataMovie context, IMapper mapper)
    {

        _context = context;
        _mapper = mapper;
    }
    [HttpPost]

    public IActionResult AddMovie(
        [FromBody] CreateMovieTdo movieTdo)
    {
        Movie filme = _mapper.Map<Movie>(movieTdo);
        filme.Id = filme.Id++;
        _context.movies.Add(filme);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetMovieById),
            new { id = filme.Id },
            filme);
    }

    [HttpGet]

    public IEnumerable<Movie> GetMovies([FromQuery] int skip = 0,
        [FromQuery] int take = 50)
    {
        return _context.movies.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult GetMovieById(int id)
    {
        var filme = _context.movies
            .FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();
        return Ok(filme);
    }
    [HttpPut("{id}")]
    public IActionResult UpdateMovie(int id, [FromBody] UpdateMovieTdo updateMovieTdo)
    {
        var filme = _context.movies
            .FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();
        _mapper.Map(updateMovieTdo, filme);
        _context.SaveChanges();
        return NoContent();
    }
}