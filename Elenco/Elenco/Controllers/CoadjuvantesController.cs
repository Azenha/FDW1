using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Elenco.Data;
using Elenco.Models;

namespace Elenco.Controllers
{
    public class CoadjuvantesController : Controller
    {
        private readonly ElencoContext _context;

        public CoadjuvantesController(ElencoContext context)
        {
            _context = context;
        }

        // GET: Coadjuvantes
        public async Task<IActionResult> Index()
        {
            var origem = _context.Coadjuvante.Include(o => o.Origem).ToList();
            var ExpA = _context.Coadjuvante.Include(o => o.ExperienciaAlfa).ToList();
            var ExpB = _context.Coadjuvante.Include(o => o.ExperienciaBeta).ToList();
            var AutA = _context.Coadjuvante.Include(o => o.AutenticidadeAlfa).ToList();
            var AutB = _context.Coadjuvante.Include(o => o.AutenticidadeBeta).ToList();
            var AutC = _context.Coadjuvante.Include(o => o.AutenticidadeGama).ToList();
            return View(await _context.Coadjuvante.ToListAsync());
        }

        // GET: Coadjuvantes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Coadjuvante == null)
            {
                return NotFound();
            }

            var coadjuvante = await _context.Coadjuvante
                .FirstOrDefaultAsync(m => m.Id == id);
            if (coadjuvante == null)
            {
                return NotFound();
            }

            return View(coadjuvante);
        }

        // GET: Coadjuvantes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Coadjuvantes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Descricao,Retrato")] Coadjuvante coadjuvante)
        {
            if (ModelState.IsValid)
            {
                _context.Add(coadjuvante);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(coadjuvante);
        }

        // GET: Coadjuvantes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Coadjuvante == null)
            {
                return NotFound();
            }

            var coadjuvante = await _context.Coadjuvante.FindAsync(id);
            if (coadjuvante == null)
            {
                return NotFound();
            }
            return View(coadjuvante);
        }

        // POST: Coadjuvantes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Descricao,Retrato")] Coadjuvante coadjuvante)
        {
            if (id != coadjuvante.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(coadjuvante);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CoadjuvanteExists(coadjuvante.Id))
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
            return View(coadjuvante);
        }

        // GET: Coadjuvantes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Coadjuvante == null)
            {
                return NotFound();
            }

            var coadjuvante = await _context.Coadjuvante
                .FirstOrDefaultAsync(m => m.Id == id);
            if (coadjuvante == null)
            {
                return NotFound();
            }

            return View(coadjuvante);
        }

        // POST: Coadjuvantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Coadjuvante == null)
            {
                return Problem("Entity set 'ElencoContext.Elenco'  is null.");
            }
            var coadjuvante = await _context.Coadjuvante.FindAsync(id);
            if (coadjuvante != null)
            {
                _context.Coadjuvante.Remove(coadjuvante);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CoadjuvanteExists(int id)
        {
          return _context.Coadjuvante.Any(e => e.Id == id);
        }
    }
}
