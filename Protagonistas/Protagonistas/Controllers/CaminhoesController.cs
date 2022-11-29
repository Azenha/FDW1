using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Protagonistas.Data;
using Protagonistas.Models;

namespace Protagonistas.Controllers
{
    public class CaminhoesController : Controller
    {
        private readonly ProtagonistasContext _context;

        public CaminhoesController(ProtagonistasContext context)
        {
            _context = context;
        }

        // GET: Caminhoes
        public async Task<IActionResult> Index()
        {
              return View(await _context.Caminho.ToListAsync());
        }

        // GET: Caminhoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Caminho == null)
            {
                return NotFound();
            }

            var caminho = await _context.Caminho
                .FirstOrDefaultAsync(m => m.Id == id);
            if (caminho == null)
            {
                return NotFound();
            }

            return View(caminho);
        }

        // GET: Caminhoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Caminhoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Descricao")] Caminho caminho)
        {
            if (ModelState.IsValid)
            {
                _context.Add(caminho);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(caminho);
        }

        // GET: Caminhoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Caminho == null)
            {
                return NotFound();
            }

            var caminho = await _context.Caminho.FindAsync(id);
            if (caminho == null)
            {
                return NotFound();
            }
            return View(caminho);
        }

        // POST: Caminhoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Descricao")] Caminho caminho)
        {
            if (id != caminho.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(caminho);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CaminhoExists(caminho.Id))
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
            return View(caminho);
        }

        // GET: Caminhoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Caminho == null)
            {
                return NotFound();
            }

            var caminho = await _context.Caminho
                .FirstOrDefaultAsync(m => m.Id == id);
            if (caminho == null)
            {
                return NotFound();
            }

            return View(caminho);
        }

        // POST: Caminhoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Caminho == null)
            {
                return Problem("Entity set 'ProtagonistasContext.Caminho'  is null.");
            }
            var caminho = await _context.Caminho.FindAsync(id);
            if (caminho != null)
            {
                _context.Caminho.Remove(caminho);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CaminhoExists(int id)
        {
          return _context.Caminho.Any(e => e.Id == id);
        }
    }
}
