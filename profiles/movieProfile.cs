using AutoMapper;
using ratingMovie.DATA.Dto;
using ratingMovie.Models;

namespace ratingMovie.profile;

public class MovieProfile : Profile
{
    public MovieProfile()
    {
        CreateMap<CreateMovieTdo, Movie>();
        CreateMap<UpdateMovieTdo, Movie>();
    }
}