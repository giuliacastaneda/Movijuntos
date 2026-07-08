using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web_App_Movijuntos.Data;
using Web_App_Movijuntos.Models;
using BCrypt.Net;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly AppDbContext _context;

    public AuthController(AppDbContext context)
    {
        _context = context;
    }

    public class LoginRequest
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }

    public class VerificarCodigoDTO
    {
        public string Email { get; set; }
        public int Codigo { get; set; }
    }

    [HttpPost("login")]
    public async Task<ActionResult> Login([FromBody] LoginRequest dto)
    {

        if (string.IsNullOrWhiteSpace(dto.Email) || string.IsNullOrWhiteSpace(dto.Senha))
        {
            return BadRequest("Email e senha são obrigatórios.");
        }

        var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == dto.Email);

        if (usuario == null)
        {
            return Unauthorized("Usuário ou senha incorretos.");
        }

        bool senhaValida = false;
        senhaValida = BCrypt.Net.BCrypt.Verify(dto.Senha, usuario.Senha);

        if (!senhaValida)
        {
            return Unauthorized("Usuário ou senha incorretos.");
        }
        else
        {

            return Ok(new { Mensagem = "Login realizado com sucesso!", UsuarioId = usuario.Id });
        }
    }

    [HttpPost("dverificador")]
    public async Task<ActionResult> VerificarCodigo([FromBody] VerificarCodigoDTO dto)
    {
        var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == dto.Email);
        if (usuario == null)
        {
            return NotFound("Usuário não encontrado.");
        }
        if (usuario.DVerificador != dto.Codigo)
        {
            return BadRequest("Código de verificação incorreto.");
        }
        return Ok("Código de verificação confirmado com sucesso.");
    }
}
