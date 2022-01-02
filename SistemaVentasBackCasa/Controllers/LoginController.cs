using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SistemaVentasBackCasa.Domain.IServices;
using SistemaVentasBackCasa.Domain.Models;
using SistemaVentasBackCasa.Utils;
using System;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SistemaVentasBackCasa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;
        private readonly IConfiguration _config;
        public LoginController(ILoginService loginService, IConfiguration config)
        {
            _loginService = loginService;
            _config = config;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UsuarioLogin usuario)
        {
            try
            {
                usuario.Password = Encriptar.EncriptarPassword(usuario.Password);
                var user = await _loginService.ValidarUsuario(usuario);
                if (user == null)
                {
                    return BadRequest(new { message = "Usuario y/o contraseña invalidos", ok = false });
                }
                string tokenString = JWTConfigurator.GetToken(user, _config);
                return Ok(new
                {
                    identificacion = user.Identificacion,
                    nombres = user.Nombres + " " + user.Apellidos,
                    token = tokenString,
                    ok = true
                }) ;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
