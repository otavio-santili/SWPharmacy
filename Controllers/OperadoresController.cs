using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SWPharmacy.Models;

namespace SWPharmacy.Controllers
{
    public class OperadoresController : Controller
    {
        private readonly Contexto _context;

        public OperadoresController(Contexto context)
        {
            _context = context;
        }

        // GET: Operadores
        public async Task<IActionResult> Index(string search = " ")
        {
            if (search == null)
            {
                return View(await _context.Operadores.ToListAsync());
            }
            return View(await _context.Operadores.Where(x => x.Nome.Contains(search)).ToListAsync());
        }

        // GET: Operadores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Operadores == null)
            {
                return NotFound();
            }

            var operador = await _context.Operadores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (operador == null)
            {
                return NotFound();
            }

            return View(operador);
        }

        // GET: Operadores/Create
        public IActionResult Create()
        {
            var TipoPermissao = Enum.GetValues(typeof(TipoPermissao)).Cast<TipoPermissao>()
            .Select(e => new SelectListItem
            {
                Value = e.ToString(),
                Text = e.ToString()
            });
            ViewBag.TipoPermissao = TipoPermissao;
            return View();
        }

        // POST: Operadores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,TipoPermissao")] Operador operador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(operador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(operador);
        }

        // GET: Operadores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Operadores == null)
            {
                return NotFound();
            }

            var operador = await _context.Operadores.FindAsync(id);
            if (operador == null)
            {
                return NotFound();
            }
            return View(operador);
        }

        // POST: Operadores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,TipoPermissao")] Operador operador)
        {
            if (id != operador.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(operador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OperadorExists(operador.Id))
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
            return View(operador);
        }

        // GET: Operadores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Operadores == null)
            {
                return NotFound();
            }

            var operador = await _context.Operadores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (operador == null)
            {
                return NotFound();
            }

            return View(operador);
        }

        // POST: Operadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Operadores == null)
            {
                return Problem("Entity set 'Contexto.Operadores'  is null.");
            }
            var operador = await _context.Operadores.FindAsync(id);
            if (operador != null)
            {
                _context.Operadores.Remove(operador);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OperadorExists(int id)
        {
          return _context.Operadores.Any(e => e.Id == id);
        }
    }
}
