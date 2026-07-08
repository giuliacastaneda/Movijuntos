using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Web_App_Movijuntos.Data;
using Web_App_Movijuntos.Models;

namespace Web_App_Movijuntos.Controllers
{
    public class CriteriosController : Controller
    {
        private readonly AppDbContext _context;

        public CriteriosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Criterios
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Criterios.Include(c => c.Avaliacao);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Criterios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var criterio = await _context.Criterios
                .Include(c => c.Avaliacao)
                .FirstOrDefaultAsync(m => m.IdCriterio == id);
            if (criterio == null)
            {
                return NotFound();
            }

            return View(criterio);
        }

        // GET: Criterios/Create
        public IActionResult Create()
        {
            ViewData["IdAvaliacao"] = new SelectList(_context.Avaliacoes, "IdAvaliacao", "IdAvaliacao");
            return View();
        }

        // POST: Criterios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCriterio,Rampas,Corrimaos,BanheiroAcess,VagasEstacion,SinalizacaoTatil,SinalizacaoSonora,SinalizaçãoVisual,CaminhoLivre,PortasCorredor,IdAvaliacao")] Criterio criterio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(criterio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdAvaliacao"] = new SelectList(_context.Avaliacoes, "IdAvaliacao", "IdAvaliacao", criterio.IdAvaliacao);
            return View(criterio);
        }

        // GET: Criterios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var criterio = await _context.Criterios.FindAsync(id);
            if (criterio == null)
            {
                return NotFound();
            }
            ViewData["IdAvaliacao"] = new SelectList(_context.Avaliacoes, "IdAvaliacao", "IdAvaliacao", criterio.IdAvaliacao);
            return View(criterio);
        }

        // POST: Criterios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdCriterio,Rampas,Corrimaos,BanheiroAcess,VagasEstacion,SinalizacaoTatil,SinalizacaoSonora,SinalizaçãoVisual,CaminhoLivre,PortasCorredor,IdAvaliacao")] Criterio criterio)
        {
            if (id != criterio.IdCriterio)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(criterio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CriterioExists(criterio.IdCriterio))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdAvaliacao"] = new SelectList(_context.Avaliacoes, "IdAvaliacao", "IdAvaliacao", criterio.IdAvaliacao);
            return View(criterio);
        }

        // GET: Criterios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var criterio = await _context.Criterios
                .Include(c => c.Avaliacao)
                .FirstOrDefaultAsync(m => m.IdCriterio == id);
            if (criterio == null)
            {
                return NotFound();
            }

            return View(criterio);
        }

        // POST: Criterios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var criterio = await _context.Criterios.FindAsync(id);
            if (criterio != null)
            {
                _context.Criterios.Remove(criterio);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CriterioExists(int id)
        {
            return _context.Criterios.Any(e => e.IdCriterio == id);
        }
    }
}
