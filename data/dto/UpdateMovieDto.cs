using System.ComponentModel.DataAnnotations;
namespace ratingMovie.DATA.Dto;
public class UpdateMovieTdo
{
    [Required(ErrorMessage = "o nome é obrigatorio")]
    [MinLength(3, ErrorMessage = "o titulo do filme tem que ter mais de três letras")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "a duração em segundos é obrigatorio")]
    [Range(70, 600, ErrorMessage = "para ser considerado um longa o filme tem que ter mais de 1h10min e menos que 10h")]
    public int DurationInMin { get; set; }

    [Required(ErrorMessage = "a nota é obrigatorio")]
    [Range(0, 10, ErrorMessage = "a nota tem que está entre 0 e 10")]
    public double? Score { get; set; }

    [Required(ErrorMessage = "os generos é obrigatorio")]
    public string? Genres { get; set; }
}