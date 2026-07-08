namespace Web_App_Movijuntos.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Security.Claims;
using System.Threading.Tasks;
using Web_App_Movijuntos.Data;
using Web_App_Movijuntos.Models;
using System.Net;
using System.Net.Mail;

[ApiController]
[Route("api/usuario")]
public class UsuarioController : ControllerBase
{
    private readonly AppDbContext _context;

    public UsuarioController(AppDbContext context)
    {
        _context = context;
    }

    // Parte do Usuario que precisamos  - DTO 
    public class AtualizarUsuarioDto
    {
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public DateOnly? Nascimento { get; set; }
    }



    // Vamos chamar um usuario especifico pelo id
    [HttpGet("{id}")]
    public async Task<ActionResult<Usuario>> GetUsuario(int id)
    {
        var usuario = await _context.Usuarios.FindAsync(id);
        if (usuario == null) return NotFound();
        return usuario;
    }


    [HttpPost]
    public async Task<ActionResult<Usuario>> CriarUsuario([FromBody] Usuario dto)
    {

        if (await _context.Usuarios.AnyAsync(u => u.Email == dto.Email))
            return Conflict("E-mail já cadastrado.");

        if (await _context.Usuarios.AnyAsync(u => u.Apelido == dto.Apelido))
            return Conflict("Apelido já cadastrado.");

        var usuario = new Usuario(dto.Nome, dto.Apelido, dto.Email, dto.Nascimento, dto.Senha);

        usuario.AlterarSenha(dto.Senha, ativarHash: 1);

        _context.Usuarios.Add(usuario);

        try
        {
            await EnviarCodigoVerificacao(usuario.Email, usuario.DVerificador);
        }
        catch (Exception ex)
        {
            return BadRequest($"Erro ao enviar e-mail: {ex.Message}");
        }

        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetUsuario), new { id = usuario.Id }, usuario);
    }


    [HttpPost("esqueci-senha")]
    public async Task<ActionResult> EsqueciSenha([FromQuery] string email)
    {
        var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == email);
        if (usuario == null)
            return NotFound("Usuário com esse e-mail não encontrado.");

        usuario.AtualizarDVerificador();
        await _context.SaveChangesAsync();
        await EnviarCodigoVerificacao(usuario.Email, usuario.DVerificador);
        return Ok("Código de verificação enviado para o e-mail.");
    }

    public async Task EnviarCodigoVerificacao(string emailDestino, int codigo)
    {
        string emailRemetente = "movijuntos.auth@gmail.com";
        string senhaApp = "ibea ottq ltvn olpc";

        using (var smtp = new SmtpClient("smtp.gmail.com")
        {
            Port = 587,
            Credentials = new NetworkCredential(emailRemetente, senhaApp),
            EnableSsl = true
        })
        {
            string htmlBody = $@"
        <!DOCTYPE html>
        <html lang='pt-BR'>
        <head>
            <meta charset='UTF-8'>
            <meta name='viewport' content='width=device-width, initial-scale=1.0'>
            <style>
                body {{
                    background-color: #f4f4f4;
                    font-family: Arial, Helvetica, sans-serif;
                    margin: 0;
                    padding: 0;
                }}
                .container {{
                    max-width: 500px;
                    background: #ffffff;
                    margin: 40px auto;
                    padding: 30px;
                    border-radius: 10px;
                    box-shadow: 0 4px 10px rgba(0,0,0,0.1);
                    text-align: center;
                }}
                h2 {{
                    color: #333333;
                }}
                p {{
                    color: #555555;
                    font-size: 16px;
                }}
                .code {{
                    display: inline-block;
                    margin: 20px 0;
                    padding: 14px 24px;
                    font-size: 24px;
                    font-weight: bold;
                    letter-spacing: 2px;
                    color: #ffffff;
                    background-color: #005bcc;
                    border-radius: 8px;
                }}
                .footer {{
                    margin-top: 25px;
                    font-size: 12px;
                    color: #999999;
                }}
            </style>
        </head>
        <body>
            <div class='container'>
                <h2>Verificação Movijuntos</h2>
                <p>Use o código abaixo para confirmar seu e-mail.</p>
                <div class='code'>{codigo}</div>
                <div class='footer'>
                    Se você não solicitou este código, ignore este e-mail.
                </div>
            </div>
        </body>
        </html>";

            var message = new MailMessage(
                from: emailRemetente,
                to: emailDestino,
                subject: "Código de verificação Movijuntos",
                body: htmlBody
            )
            {
                IsBodyHtml = true
            };

            await smtp.SendMailAsync(message);
        }
    }


    // GET: /api/usuario/idporEmail?email=exemplo@dominio.com
    [HttpGet("idporEmail")]
    public async Task<ActionResult> GetIdPorEmail([FromQuery] string email)
    {
        if (string.IsNullOrWhiteSpace(email))
            return BadRequest("Email é obrigatório.");

        var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == email);

        if (usuario == null)
            return NotFound("Usuário não encontrado.");

        return Ok(new { userId = usuario.Id });
    }

    [HttpGet("meuperfil")]

    [Authorize] // <-- Garante que o usuário precisa estar logado para acessar.

    public async Task<IActionResult> GetMeuPerfil()
    {
        var userEmail = User.FindFirstValue(ClaimTypes.Email);

        if (string.IsNullOrEmpty(userEmail))
        {
            return Unauthorized("Email não encontrado no token.");
        }

        var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == userEmail);

        if (usuario == null)
        {
            return NotFound("Usuário não encontrado.");
        }

        var dadosPerfil = new
        {
            usuario.Id,
            usuario.Nome,
            usuario.Apelido,
            usuario.Email,
            usuario.Nascimento
        };

        return Ok(dadosPerfil);
    }


    // PUT: /api/Usuarios/meuperfil
    // Endpoint para atualizar os dados do usuário logado. 

    [HttpPut("meuperfil")]
    [Authorize] // <-- Protegendo o endpoint

    public async Task<IActionResult> UpdateMeuPerfil([FromBody] Usuario dadosAtualizados)
    {
        var userEmail = User.FindFirstValue(ClaimTypes.Email);

        if (string.IsNullOrEmpty(userEmail))
        {
            return Unauthorized();
        }
        var usuarioParaAtualizar = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == userEmail);

        if (usuarioParaAtualizar == null)
        {
            return NotFound("Usuário não encontrado.");
        }

        // Atualizando os campos permitidos 

        usuarioParaAtualizar.AlterarNome(dadosAtualizados.Nome);
        usuarioParaAtualizar.AlterarApelido(dadosAtualizados.Apelido);
        usuarioParaAtualizar.AlterarNascimento(dadosAtualizados.Nascimento);


        _context.Usuarios.Update(usuarioParaAtualizar);
        await _context.SaveChangesAsync();

        return Ok("Perfil alterado com sucesso");

    }

    [HttpPut("{id}")]
    public async Task<IActionResult> AtualizarUsuarioPorId(int id, [FromBody] AtualizarUsuarioDto dados)
    {
        var usuario = await _context.Usuarios.FindAsync(id);
        if (usuario == null)
            return NotFound("Usuário não encontrado.");

        if (dados.Nome != null) usuario.AlterarNome(dados.Nome);
        if (dados.Apelido != null) usuario.AlterarApelido(dados.Apelido);
        if (dados.Nascimento.HasValue) usuario.AlterarNascimento(dados.Nascimento.Value);

        _context.Usuarios.Update(usuario);
        await _context.SaveChangesAsync();

        return Ok(usuario);
    }


}
