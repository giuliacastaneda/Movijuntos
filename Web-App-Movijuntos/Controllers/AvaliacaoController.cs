using Microsoft.AspNetCore.Mvc;
using Web_App_Movijuntos.Data;
using Web_App_Movijuntos.Models;
using Microsoft.EntityFrameworkCore;

namespace Web_App_Movijuntos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AvaliacaoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AvaliacaoController(AppDbContext context)
        {
            _context = context;
        }

        // POST: api/avaliacao
        [HttpPost]
        public async Task<IActionResult> PostAvaliacao([FromBody] Avaliacao avaliacao)
        {
            if (avaliacao == null)
                return BadRequest("Dados inválidos.");

            _context.Avaliacoes.Add(avaliacao);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Avaliação salva com sucesso!", avaliacao });
        }

        // GET: api/avaliacao
        [HttpGet]
        public async Task<IActionResult> GetAvaliacoes()
        {
            var avaliacoes = await _context.Avaliacoes.ToListAsync();
            return Ok(avaliacoes);
        }

        // GET: api/avaliacao/media
        [HttpGet("media")]
        public async Task<IActionResult> GetMedia()
        {
            if (!_context.Avaliacoes.Any())
                return Ok(0);

            var media = await _context.Avaliacoes.AverageAsync(a => a.Nota);
            return Ok(media);
        }

        // GET: api/avaliacao/filtrar?notaMinima=4
        [HttpGet("filtrar")]
        public async Task<IActionResult> Filtrar([FromQuery] int? notaMinima)
        {
            var query = _context.Avaliacoes.AsQueryable();

            if (notaMinima.HasValue)
                query = query.Where(a => a.Nota >= notaMinima.Value);

            var resultado = await query.ToListAsync();
            return Ok(resultado);
        }
    }
}
