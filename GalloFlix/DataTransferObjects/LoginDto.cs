using System.ComponentModel.DataAnnotations;

namespace GalloFlix.DataTransferObjects;

public class LoginDto
{
    [Display(Name = "Email ou Nome de Usuário")]
    [Required(ErrorMessage = "Por Favor, informe seu email ou nome de usuário")]
    public string Email { get; set; }
    [Display(Name = "Senha de Acesso")]
    [Required(ErrorMessage = "Por Favor, informe a senha")]
    public string Password { get; set; }
    [Display(Name = "Manter Conectado?")]
    public bool RememberMe { get; set; }
    
    public string ReturnUrl { get; set; }

}

