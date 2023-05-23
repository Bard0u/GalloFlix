using GalloFlix.DataTransferObjects;
using GalloFlix.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace GalloFlix.Controllers;

[Authorize(Roles = "Administrador")]
public class AccountController : Controller
{
    private readonly ILogger<AccountController> _logger;

    private readonly SignInManager<AppUser> _signInManager;

    private readonly UserManager<AppUser> _userManager;

    public AccountController(ILogger<AccountController> logger,
    SignInManager<AppUser> signInManager,
    UserManager<AppUser>userManager)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    
 

    [HttpGet]
    [AllowAnonymous]
    public IActionResult Login(string returnUrl)
    {
        LoginDto loginDto = new();
        loginDto.ReturnUrl = returnUrl ?? Url.Content("~/");
        return View(loginDto);
    }

    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> Login(LoginDto login)
    {
       if (ModelState.IsValid)
        {
            var result = await _signInManager.PasswordSignInAsync(
                login.Email, login.Password, login.RememberMe, true
            );
            if(result.Succeeded)
            {
                _logger.LogInformation($"Usuario {login.Email} acessou o sistema");
                return LocalRedirect(login.ReturnUrl);
            }
            if(result.IsLockedOut)
            {
                _logger.LogWarning($"Usuario {login.Email} está bloqueado");
                return RedirectToAction("Lockout");
            }
            ModelState.AddModelError("login","Usuário e/ou Senha Inválidos!!!");

        }
        return View(login);

        
    }

}
