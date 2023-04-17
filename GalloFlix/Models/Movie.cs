using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalloFlix.Models;

[Table("Movie")]
public class Movie
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Display(Name = "Título Original")]
    [Required(ErrorMessage = "O Titulo Original é Obrigatório")]
    [StringLength(100, ErrorMessage = "O Titulo Original deve possuir no maximo 100 caracteres")]
    public string OriginalTitle { get; set; }

    [Display(Name = "Título")]
    [Required(ErrorMessage = "O Titulo é Obrigatório")]
    [StringLength(100, ErrorMessage = "O Titulo deve possuir no maximo 100 caracteres")]
    public string Title { get; set; }

    [Display(Name = "Sinopse")]
    [StringLength(5000, ErrorMessage = "O Titulo deve possuir no maximo 5000 caracteres")]
    public string Synopsis { get; set; }

    public int MovieYear { get; set; }

    public int Duration { get; set; }

    public int AgeRating { get; set; }

    public string Image { get; set; }

}
