using Microsoft.EntityFrameworkCore;
using ratingMovie.Models;
namespace ratingMovie.DATA;
using ratingMovie.Interface;

public class DataMovie : DbContext, IcontextMovie
{
    public DataMovie(DbContextOptions<DataMovie> options) : base(options)
    {

    }
    public DbSet<Movie> movies { get; set; }
}