using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Aula29.Models;

namespace Aula29.Controllers
{
    public class AtorController : Controller
    {
        private readonly CatalogoContext _context;

        public AtorController(CatalogoContext context)
        {
            _context = context;
        }

        // GET: Ator
        public async Task<IActionResult> Index()
        {
              return _context.Atores != null ? 
                          View(await _context.Atores.ToListAsync()) :
                          Problem("Entity set 'CatalogoContext.Atores'  is null.");
        }

        // GET: Ator/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Atores == null)
            {
                return NotFound();
            }

            var atorModel = await _context.Atores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (atorModel == null)
            {
                return NotFound();
            }

            return View(atorModel);
        }

        // GET: Ator/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ator/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,SobreNome")] AtorModel atorModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(atorModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(atorModel);
        }

        // GET: Ator/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Atores == null)
            {
                return NotFound();
            }

            var atorModel = await _context.Atores.FindAsync(id);
            if (atorModel == null)
            {
                return NotFound();
            }
            return View(atorModel);
        }

        // POST: Ator/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,SobreNome")] AtorModel atorModel)
        {
            if (id != atorModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(atorModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AtorModelExists(atorModel.Id))
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
            return View(atorModel);
        }

        // GET: Ator/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Atores == null)
            {
                return NotFound();
            }

            var atorModel = await _context.Atores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (atorModel == null)
            {
                return NotFound();
            }

            return View(atorModel);
        }

        // POST: Ator/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Atores == null)
            {
                return Problem("Entity set 'CatalogoContext.Atores'  is null.");
            }
            var atorModel = await _context.Atores.FindAsync(id);
            if (atorModel != null)
            {
                _context.Atores.Remove(atorModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AtorModelExists(int id)
        {
          return (_context.Atores?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
