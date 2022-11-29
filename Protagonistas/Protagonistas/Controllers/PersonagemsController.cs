using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using Protagonistas.Data;
using Protagonistas.Models;
using Protagonistas.Models.ViewModels;

namespace Protagonistas.Controllers
{
    public class PersonagemsController : Controller
    {
        private readonly ProtagonistasContext _context;

        public PersonagemsController(ProtagonistasContext context)
        {
            _context = context;
        }

        // GET: Personagems
        public async Task<IActionResult> Index()
        {
            var ancestralidade = _context.Personagem.Include(o => o.Ancestralidade).ToList();
            var biografia = _context.Personagem.Include(o => o.Biografia).ToList();
            var caminho = _context.Personagem.Include(o => o.Caminho).ToList();
            return View(await _context.Personagem.ToListAsync());
        }

        // GET: Personagems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Personagem == null)
            {
                return NotFound();
            }
            var ancestralidade = _context.Personagem.Include(o => o.Ancestralidade).FirstOrDefault(c => c.Id == id);
            var biografia = _context.Personagem.Include(o => o.Biografia).FirstOrDefault(c => c.Id == id);
            var caminho = _context.Personagem.Include(o => o.Caminho).FirstOrDefault(c => c.Id == id);
            var personagem = await _context.Personagem
                .FirstOrDefaultAsync(m => m.Id == id);
            if (personagem == null)
            {
                return NotFound();
            }

            return View(personagem);
        }

        // GET: Personagems/Create
        public IActionResult Create()
        {
            var viewModel = new PersonagemFormViewModel();
            viewModel.Ancestralidades = _context.Ancestralidade.ToList();
            viewModel.Biografias = _context.Biografia.ToList();
            viewModel.Caminhos = _context.Caminho.ToList();
            return View(viewModel);
        }

        // POST: Personagems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public IActionResult Create(Personagem personagem)
        {
            _context.Personagem.Add(personagem);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,Nome,Descricao,Retrato,Ancestralidade,Biografia,Caminho")] Personagem personagem)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(personagem);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(personagem);
        //}

        // GET: Personagems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Personagem == null)
            {
                return NotFound();
            }
            Personagem? personagem = _context.Personagem.Include(s => s.Ancestralidade)
                                                       .Include(o => o.Biografia)
                                                       .Include(o => o.Caminho)
                                                       .FirstOrDefault(s => s.Id == id);
            //var personagem = await _context.Personagem.FindAsync(id);
            if (personagem == null)
            {
                return NotFound();
            }
            //return View(personagem);
            var viewModel = new PersonagemFormViewModel();
            viewModel.Personagem = personagem;
            viewModel.Ancestralidades = _context.Ancestralidade.ToArray();
            viewModel.Biografias = _context.Biografia.ToArray();
            viewModel.Caminhos = _context.Caminho.ToArray();
            return View(viewModel);
        }

        // POST: Personagems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public IActionResult Edit(Personagem personagem)
        {
            _context.Personagem.Update(personagem);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Descricao,Retrato,Ancestralidade,Biografia,Caminho")] Personagem personagem)
        //{
        //    if (id != personagem.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(personagem);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!PersonagemExists(personagem.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(personagem);
        //}

        // GET: Personagems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Personagem == null)
            {
                return NotFound();
            }

            var personagem = await _context.Personagem
                .FirstOrDefaultAsync(m => m.Id == id);
            if (personagem == null)
            {
                return NotFound();
            }

            return View(personagem);
        }

        // POST: Personagems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Personagem == null)
            {
                return Problem("Entity set 'ProtagonistasContext.Personagem'  is null.");
            }
            var personagem = await _context.Personagem.FindAsync(id);
            if (personagem != null)
            {
                _context.Personagem.Remove(personagem);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonagemExists(int id)
        {
          return _context.Personagem.Any(e => e.Id == id);
        }
    }
}
