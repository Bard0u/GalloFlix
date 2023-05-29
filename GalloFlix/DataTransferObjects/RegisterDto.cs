using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GalloFlix.DataTransferObjects;

public class RegisterDto
{
    [Display(Name = "Nome Completo")]
    [Required(ErrorMessage = "Por favor, informe seu nome")]
    [StringLength(60, ErrorMessage = "O nome deve possuir no maximo 60 caracteres")]
    public string Name { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Data de Nascimento")]
    [Required(ErrorMessage = "Por favor, informe sua data de nascimento")]
    public DateTime DateOfBirth { get; set; }

    [Required(ErrorMessage = "Por favor, informe seu Email")]
    [StringLength(100, ErrorMessage = "O Email deve possuir no maximo 100 caracteres")]
    [EmailAddress(ErrorMessage = "Por favor informe um email valido")]
    public string Email { get; set; }

    [Display(Name = "Senha de Acesso")]
    [Required(ErrorMessage = "Por favor, informe sua senha")]
    [DataType(DataType.Password)]
    [StringLength(20, MinimumLength =6 , ErrorMessage = "A senha deve possuir no minimo 6 e no maximo 20 caracteres")]
    public string Password { get; set; }

    [Display(Name = "Confirmar Senha de Acesso")]
    [Required(ErrorMessage = "Por favor, informe sua senha")]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage ="As Senhas não Conferem")]
   
    public string ConfirmPassword { get; set; }

}