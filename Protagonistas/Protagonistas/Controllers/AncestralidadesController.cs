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
    public class AncestralidadesController : Controller
    {
        private readonly ProtagonistasContext _context;

        public AncestralidadesController(ProtagonistasContext context)
        {
            _context = context;
        }

        // GET: Ancestralidades
        public async Task<IActionResult> Index()
        {
              return View(await _context.Ancestralidade.ToListAsync());
        }

        // GET: Ancestralidades/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Ancestralidade == null)
            {
                return NotFound();
            }

            var ancestralidade = await _context.Ancestralidade
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ancestralidade == null)
            {
                return NotFound();
            }

            return View(ancestralidade);
        }

        // GET: Ancestralidades/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ancestralidades/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Descricao")] Ancestralidade ancestralidade)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ancestralidade);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ancestralidade);
        }

        // GET: Ancestralidades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Ancestralidade == null)
            {
                return NotFound();
            }

            var ancestralidade = await _context.Ancestralidade.FindAsync(id);
            if (ancestralidade == null)
            {
                return NotFound();
            }
            return View(ancestralidade);
        }

        // POST: Ancestralidades/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Descricao")] Ancestralidade ancestralidade)
        {
            if (id != ancestralidade.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ancestralidade);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AncestralidadeExists(ancestralidade.Id))
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
            return View(ancestralidade);
        }

        // GET: Ancestralidades/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Ancestralidade == null)
            {
                return NotFound();
            }

            var ancestralidade = await _context.Ancestralidade
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ancestralidade == null)
            {
                return NotFound();
            }

            return View(ancestralidade);
        }

        // POST: Ancestralidades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Ancestralidade == null)
            {
                return Problem("Entity set 'ProtagonistasContext.Ancestralidade'  is null.");
            }
            var ancestralidade = await _context.Ancestralidade.FindAsync(id);
            if (ancestralidade != null)
            {
                _context.Ancestralidade.Remove(ancestralidade);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AncestralidadeExists(int id)
        {
          return _context.Ancestralidade.Any(e => e.Id == id);
        }
    }
}
