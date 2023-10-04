using Healthy_Clinic_Manha_Edu.Domains;
using Healthy_Clinic_Manha_Edu.Interfaces;
using Healthy_Clinic_Manha_Edu.Login;
using Healthy_Clinic_Manha_Edu.Repositores;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Healthy_Clinic_Manha_Edu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]


    public class LoginController : ControllerBase
    {

        private IUsuarioRepository _usuario;

        public LoginController()
        {
            _usuario = new UsuarioRepository();
        }

        [HttpPost]
        public IActionResult Login (LoginClass usuario)
        {
            try
            {
                Usuario usuarioBuscado = _usuario.BuscarPorEmailSenha(usuario.Email!, usuario.Senha!);

                if (usuarioBuscado == null)
                {
                    return StatusCode(401, "Email ou senha inválidos!");
                }

                //Lógica do token:

                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Jti,usuarioBuscado.IdUsuario.ToString()),
                    new Claim(JwtRegisteredClaimNames.Email, usuarioBuscado.Email),
                    new Claim(JwtRegisteredClaimNames.Name, usuarioBuscado.Nome),
                    new Claim(ClaimTypes.Role, usuarioBuscado.TiposUsuario.Nome),
                };

                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("HealthyManha-chave-autenticacao"));

                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken
                (
                    issuer: "Healthy_Clinic_Manha_Edu",
                    audience: "Healthy_Clinic_Manha_Edu",
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(10),
                    signingCredentials: creds
                );

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });


                return Ok(usuarioBuscado);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }
    }
}
