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
    public class AutenticidadesController : Controller
    {
        private readonly NpcManagerContext _context;

        public AutenticidadesController(NpcManagerContext context)
        {
            _context = context;
        }

        // GET: Autenticidades
        public async Task<IActionResult> Index()
        {
              return View(await _context.Autenticidade.ToListAsync());
        }

        // GET: Autenticidades/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Autenticidade == null)
            {
                return NotFound();
            }

            var autenticidade = await _context.Autenticidade
                .FirstOrDefaultAsync(m => m.Id == id);
            if (autenticidade == null)
            {
                return NotFound();
            }

            return View(autenticidade);
        }

        // GET: Autenticidades/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Autenticidades/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Descricao")] Autenticidade autenticidade)
        {
            if (ModelState.IsValid)
            {
                _context.Add(autenticidade);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(autenticidade);
        }

        // GET: Autenticidades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Autenticidade == null)
            {
                return NotFound();
            }

            var autenticidade = await _context.Autenticidade.FindAsync(id);
            if (autenticidade == null)
            {
                return NotFound();
            }
            return View(autenticidade);
        }

        // POST: Autenticidades/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Descricao")] Autenticidade autenticidade)
        {
            if (id != autenticidade.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(autenticidade);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AutenticidadeExists(autenticidade.Id))
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
            return View(autenticidade);
        }

        // GET: Autenticidades/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Autenticidade == null)
            {
                return NotFound();
            }

            var autenticidade = await _context.Autenticidade
                .FirstOrDefaultAsync(m => m.Id == id);
            if (autenticidade == null)
            {
                return NotFound();
            }

            return View(autenticidade);
        }

        // POST: Autenticidades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Autenticidade == null)
            {
                return Problem("Entity set 'NpcManagerContext.Autenticidade'  is null.");
            }
            var autenticidade = await _context.Autenticidade.FindAsync(id);
            if (autenticidade != null)
            {
                _context.Autenticidade.Remove(autenticidade);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AutenticidadeExists(int id)
        {
          return _context.Autenticidade.Any(e => e.Id == id);
        }
    }
}
