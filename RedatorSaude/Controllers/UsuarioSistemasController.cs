using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RedatorSaude.Data;
using RedatorSaude.Models;

namespace RedatorSaude.Controllers
{
    public class UsuarioSistemasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsuarioSistemasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UsuarioSistemas
        public async Task<IActionResult> Index()
        {
            return View(await _context.UsuarioSistema.ToListAsync());
        }

        // GET: UsuarioSistemas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarioSistema = await _context.UsuarioSistema
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuarioSistema == null)
            {
                return NotFound();
            }

            return View(usuarioSistema);
        }

        // GET: UsuarioSistemas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UsuarioSistemas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Login,PecaCriada,DataCriada")] UsuarioSistema usuarioSistema)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuarioSistema);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuarioSistema);
        }

        // GET: UsuarioSistemas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarioSistema = await _context.UsuarioSistema.FindAsync(id);
            if (usuarioSistema == null)
            {
                return NotFound();
            }
            return View(usuarioSistema);
        }

        // POST: UsuarioSistemas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Login,PecaCriada,DataCriada")] UsuarioSistema usuarioSistema)
        {
            if (id != usuarioSistema.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuarioSistema);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioSistemaExists(usuarioSistema.Id))
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
            return View(usuarioSistema);
        }

        // GET: UsuarioSistemas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarioSistema = await _context.UsuarioSistema
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuarioSistema == null)
            {
                return NotFound();
            }

            return View(usuarioSistema);
        }

        // POST: UsuarioSistemas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuarioSistema = await _context.UsuarioSistema.FindAsync(id);
            _context.UsuarioSistema.Remove(usuarioSistema);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioSistemaExists(int id)
        {
            return _context.UsuarioSistema.Any(e => e.Id == id);
        }
    }
}
