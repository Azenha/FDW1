using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NpcManager.Data;
using NpcManager.Models;

namespace NpcManager.Controllers
{
    public class ExperienciasController : Controller
    {
        private readonly NpcManagerContext _context;

        public ExperienciasController(NpcManagerContext context)
        {
            _context = context;
        }

        // GET: Experiencias
        public async Task<IActionResult> Index()
        {
              return View(await _context.Experiencia.ToListAsync());
        }

        // GET: Experiencias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Experiencia == null)
            {
                return NotFound();
            }

            var experiencia = await _context.Experiencia
                .FirstOrDefaultAsync(m => m.Id == id);
            if (experiencia == null)
            {
                return NotFound();
            }

            return View(experiencia);
        }

        // GET: Experiencias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Experiencias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Descricao")] Experiencia experiencia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(experiencia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(experiencia);
        }

        // GET: Experiencias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Experiencia == null)
            {
                return NotFound();
            }

            var experiencia = await _context.Experiencia.FindAsync(id);
            if (experiencia == null)
            {
                return NotFound();
            }
            return View(experiencia);
        }

        // POST: Experiencias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Descricao")] Experiencia experiencia)
        {
            if (id != experiencia.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(experiencia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExperienciaExists(experiencia.Id))
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
            return View(experiencia);
        }

        // GET: Experiencias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Experiencia == null)
            {
                return NotFound();
            }

            var experiencia = await _context.Experiencia
                .FirstOrDefaultAsync(m => m.Id == id);
            if (experiencia == null)
            {
                return NotFound();
            }

            return View(experiencia);
        }

        // POST: Experiencias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Experiencia == null)
            {
                return Problem("Entity set 'NpcManagerContext.Experiencia'  is null.");
            }
            var experiencia = await _context.Experiencia.FindAsync(id);
            if (experiencia != null)
            {
                _context.Experiencia.Remove(experiencia);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExperienciaExists(int id)
        {
          return _context.Experiencia.Any(e => e.Id == id);
        }
    }
}
