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
    public class BiografiasController : Controller
    {
        private readonly ProtagonistasContext _context;

        public BiografiasController(ProtagonistasContext context)
        {
            _context = context;
        }

        // GET: Biografias
        public async Task<IActionResult> Index()
        {
              return View(await _context.Biografia.ToListAsync());
        }

        // GET: Biografias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Biografia == null)
            {
                return NotFound();
            }

            var biografia = await _context.Biografia
                .FirstOrDefaultAsync(m => m.Id == id);
            if (biografia == null)
            {
                return NotFound();
            }

            return View(biografia);
        }

        // GET: Biografias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Biografias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Descricao")] Biografia biografia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(biografia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(biografia);
        }

        // GET: Biografias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Biografia == null)
            {
                return NotFound();
            }

            var biografia = await _context.Biografia.FindAsync(id);
            if (biografia == null)
            {
                return NotFound();
            }
            return View(biografia);
        }

        // POST: Biografias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Descricao")] Biografia biografia)
        {
            if (id != biografia.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(biografia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BiografiaExists(biografia.Id))
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
            return View(biografia);
        }

        // GET: Biografias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Biografia == null)
            {
                return NotFound();
            }

            var biografia = await _context.Biografia
                .FirstOrDefaultAsync(m => m.Id == id);
            if (biografia == null)
            {
                return NotFound();
            }

            return View(biografia);
        }

        // POST: Biografias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Biografia == null)
            {
                return Problem("Entity set 'ProtagonistasContext.Biografia'  is null.");
            }
            var biografia = await _context.Biografia.FindAsync(id);
            if (biografia != null)
            {
                _context.Biografia.Remove(biografia);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BiografiaExists(int id)
        {
          return _context.Biografia.Any(e => e.Id == id);
        }
    }
}
