using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalloFlix.Models;

[Table("Genre")]
public class Genre
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Display(Name = "Nome")]
    [Required(ErrorMessage = "O Nome do Gênero é Obrigatório")]
    [StringLength(30,ErrorMessage = "o nome deve possuir no maximo 30 caracteres")]
    public string Name { get; set; }
}
