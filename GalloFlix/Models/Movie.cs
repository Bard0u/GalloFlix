using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalloFlix.Models;

[Table("Movie")]
public class Movie
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Display(Name = "Título")]
    [Required(ErrorMessage = "O Titulo é Obrigatório")]
    [StringLength(100, ErrorMessage = "O Titulo deve possuir no maximo 100 caracteres")]
    public string Title { get; set; }

    [Display(Name = "Título Original")]
    [Required(ErrorMessage = "O Titulo Original é Obrigatório")]
    [StringLength(100, ErrorMessage = "O Titulo Original deve possuir no maximo 100 caracteres")]
    public string OriginalTitle { get; set; }
    
    [Display(Name = "Sinopse")]
    [Required(ErrorMessage ="Sinopse obrigatoria")]
    [StringLength(8000, ErrorMessage = "O Titulo deve possuir no maximo 8000 caracteres")]
    public string Synopsis { get; set; }
    [Column(TypeName = "Year")]
    [Display(Name = "Ano de Estreia")]
    [Required(ErrorMessage ="O ano de estreia é obrigatorio")]
    public Int16 MovieYear { get; set; }
    [Display(Name = "Duração(minutos)")]
    [Required(ErrorMessage = "A duração é obrigatoria")]
    public Int16 Duration { get; set; }
    [Display(Name ="Classificação etaria")]
    [Required(ErrorMessage ="A classificação etaria é obrigatoria")]
    public byte AgeRating { get; set; }
    [StringLength(200)]
    [Display(Name = "Foto")]
    public string Image { get; set; }

    [NotMapped]
    [Display(Name ="Duração")]
    public String HourDuration { get {
         return TimeSpan.FromMinutes(Duration).ToString(@"%h 'h' mm 'min'");

    }}
    public ICollection<MovieComment> Comments { get; set; } 
    public ICollection<MovieGenre> Genres { get; set; } 
    public ICollection<MovieRating> Ratings { get; set; } 


}
