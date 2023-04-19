using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BiebCWebsite.Data;
using BiebCWebsite.Models;

namespace BiebCWebsite.Controllers
{
    public class GuestModelsController : Controller
    {
        private readonly BiebCWebsiteContext _context;

        public GuestModelsController(BiebCWebsiteContext context)
        {
            _context = context;
        }

        // GET: GuestModels
        public async Task<IActionResult> Index()
        {
              return _context.GuestModel != null ? 
                          View(await _context.GuestModel.ToListAsync()) :
                          Problem("Entity set 'BiebCWebsiteContext.GuestModel'  is null.");
        }

        // GET: GuestModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.GuestModel == null)
            {
                return NotFound();
            }

            var guestModel = await _context.GuestModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (guestModel == null)
            {
                return NotFound();
            }

            return View(guestModel);
        }

        // GET: GuestModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GuestModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,lastName,Email,Phone,PostalCode")] GuestModel guestModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(guestModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(guestModel);
        }

        // GET: GuestModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.GuestModel == null)
            {
                return NotFound();
            }

            var guestModel = await _context.GuestModel.FindAsync(id);
            if (guestModel == null)
            {
                return NotFound();
            }
            return View(guestModel);
        }

        // POST: GuestModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,lastName,Email,Phone,PostalCode")] GuestModel guestModel)
        {
            if (id != guestModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(guestModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GuestModelExists(guestModel.Id))
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
            return View(guestModel);
        }

        // GET: GuestModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.GuestModel == null)
            {
                return NotFound();
            }

            var guestModel = await _context.GuestModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (guestModel == null)
            {
                return NotFound();
            }

            return View(guestModel);
        }

        // POST: GuestModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.GuestModel == null)
            {
                return Problem("Entity set 'BiebCWebsiteContext.GuestModel'  is null.");
            }
            var guestModel = await _context.GuestModel.FindAsync(id);
            if (guestModel != null)
            {
                _context.GuestModel.Remove(guestModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GuestModelExists(int id)
        {
          return (_context.GuestModel?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
