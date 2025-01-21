using Microsoft.EntityFrameworkCore;
using ratingMovie.Models;
namespace ratingMovie.Interface;
public interface IcontextMovie
{
    public DbSet<Movie> movies { get; set; }
}