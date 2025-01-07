using Microsoft.EntityFrameworkCore;
using ratingMovie.Models;
namespace ratingMovie.DATA;

public class DataMovie : DbContext
{
    public DataMovie(DbContextOptions<DataMovie> options) : base(options)
    {

    }
    public DbSet<Movie> Movies { get; set; }
}