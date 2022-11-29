using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Elenco.Data;
using Elenco.Models;
using Elenco.Models.ViewModels;
using NuGet.Protocol.Plugins;

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
            var origem = _context.Coadjuvante.Include(o => o.Origem).FirstOrDefault(c => c.Id == id);
            var ExpA = _context.Coadjuvante.Include(o => o.ExperienciaAlfa).FirstOrDefault(c => c.Id == id);
            var ExpB = _context.Coadjuvante.Include(o => o.ExperienciaBeta).FirstOrDefault(c => c.Id == id);
            var AutA = _context.Coadjuvante.Include(o => o.AutenticidadeAlfa).FirstOrDefault(c => c.Id == id);
            var AutB = _context.Coadjuvante.Include(o => o.AutenticidadeBeta).FirstOrDefault(c => c.Id == id);
            var AutC = _context.Coadjuvante.Include(o => o.AutenticidadeGama).FirstOrDefault(c => c.Id == id);
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
        public async Task<IActionResult> Create([Bind("Id,Nome,Descricao,Retrato,Origem,ExperienciaAlfa,ExperienciaBeta,AutenticidadeAlfa,AutenticidadeBeta,AutenticidadeGama")] Coadjuvante coadjuvante)
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
        public async Task<IActionResult> Edit(int? id, Origem? orig, Experiencia? expA, Experiencia? expB, Autenticidade? autA, Autenticidade? autB, Autenticidade? autC)
        {
            if (id == null || _context.Coadjuvante == null)
            {
                return NotFound();
            }
            var coadjuvante = await _context.Coadjuvante.FindAsync(id);
            //Coadjuvante coadjuvante = await _context.Coadjuvante.Include(Origem).Include.(ExperienciaAlfa);
                                                          //.Include.(ExperienciaBeta)
                                                          //.Include.(AutenticidadeAlfa)
                                                          //.Include.(AutenticidadeBeta)
                                                          //.Include.(AutenticidadeGama)
                                                          /*.FirstOrDefault(s => s.Id == id);*/
            
            var Orig = _context.Coadjuvante.Include(s => s.Origem).FirstOrDefault(s => s.Id == id);
            var ExpA = _context.Coadjuvante.Include(s => s.ExperienciaAlfa).FirstOrDefault(s => s.Id == id);
            var ExpB = _context.Coadjuvante.Include(s => s.ExperienciaBeta).FirstOrDefault(s => s.Id == id);
            var AutA = _context.Coadjuvante.Include(s => s.AutenticidadeAlfa).FirstOrDefault(s => s.Id == id);
            var AutB = _context.Coadjuvante.Include(s => s.AutenticidadeBeta).FirstOrDefault(s => s.Id == id);
            var AutC = _context.Coadjuvante.Include(s => s.AutenticidadeGama).FirstOrDefault(s => s.Id == id);
            //var coadjuvante = await _context.Coadjuvante.FindAsync(id);
            if (coadjuvante == null)
            {
                return NotFound();
            }
            var viewModel = new CoadjuvanteFormViewModel();
            viewModel.Coadjuvante = coadjuvante;
            viewModel.Coadjuvante.Origem = orig.ToArray();
            viewModel.Coadjuvante.ExperienciaAlfa = expA;
            viewModel.Coadjuvante.ExperienciaBeta = expB;
            viewModel.Coadjuvante.AutenticidadeAlfa = autA;
            viewModel.Coadjuvante.AutenticidadeBeta = autB;
            viewModel.Coadjuvante.AutenticidadeGama = autC;
            return View(viewModel);
        }

        // POST: Coadjuvantes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Descricao,Retrato,Origem,ExperienciaAlfa,ExperienciaBeta,AutenticidadeAlfa,AutenticidadeBeta,AutenticidadeGama")] Coadjuvante coadjuvante)
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
            var origem = _context.Coadjuvante.Include(o => o.Origem).FirstOrDefault(c => c.Id == id);
            var ExpA = _context.Coadjuvante.Include(o => o.ExperienciaAlfa).FirstOrDefault(c => c.Id == id);
            var ExpB = _context.Coadjuvante.Include(o => o.ExperienciaBeta).FirstOrDefault(c => c.Id == id);
            var AutA = _context.Coadjuvante.Include(o => o.AutenticidadeAlfa).FirstOrDefault(c => c.Id == id);
            var AutB = _context.Coadjuvante.Include(o => o.AutenticidadeBeta).FirstOrDefault(c => c.Id == id);
            var AutC = _context.Coadjuvante.Include(o => o.AutenticidadeGama).FirstOrDefault(c => c.Id == id);
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
