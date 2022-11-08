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
    public class NpcsController : Controller
    {
        private readonly NpcManagerContext _context;

        public NpcsController(NpcManagerContext context)
        {
            _context = context;
        }

        // GET: Npcs
        public async Task<IActionResult> Index()
        {
              return View(await _context.Npc.ToListAsync());
        }

        // GET: Npcs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Npc == null)
            {
                return NotFound();
            }

            var npc = await _context.Npc
                .FirstOrDefaultAsync(m => m.Id == id);
            if (npc == null)
            {
                return NotFound();
            }

            return View(npc);
        }

        // GET: Npcs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Npcs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Descricao,Retrato")] Npc npc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(npc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(npc);
        }

        // GET: Npcs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Npc == null)
            {
                return NotFound();
            }

            var npc = await _context.Npc.FindAsync(id);
            if (npc == null)
            {
                return NotFound();
            }
            return View(npc);
        }

        // POST: Npcs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Descricao,Retrato")] Npc npc)
        {
            if (id != npc.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(npc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NpcExists(npc.Id))
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
            return View(npc);
        }

        // GET: Npcs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Npc == null)
            {
                return NotFound();
            }

            var npc = await _context.Npc
                .FirstOrDefaultAsync(m => m.Id == id);
            if (npc == null)
            {
                return NotFound();
            }

            return View(npc);
        }

        // POST: Npcs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Npc == null)
            {
                return Problem("Entity set 'NpcManagerContext.Npc'  is null.");
            }
            var npc = await _context.Npc.FindAsync(id);
            if (npc != null)
            {
                _context.Npc.Remove(npc);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NpcExists(int id)
        {
          return _context.Npc.Any(e => e.Id == id);
        }
    }
}
