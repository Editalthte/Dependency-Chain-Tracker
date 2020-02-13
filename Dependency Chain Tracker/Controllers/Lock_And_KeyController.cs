using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Dependency_Chain_Tracker;
using Dependency_Chain_Tracker.Data;

namespace Dependency_Chain_Tracker.Controllers
{
    public class Lock_And_KeyController : Controller
    {
        private readonly Dependency_Chain_TrackerContext _context;

        public Lock_And_KeyController(Dependency_Chain_TrackerContext context)
        {
            _context = context;
        }

        // GET: Lock_And_Key
        public async Task<IActionResult> Index()
        {
            return View(await _context.Lock_And_Key.ToListAsync());
        }

        // GET: Lock_And_Key/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lock_And_Key = await _context.Lock_And_Key
                .FirstOrDefaultAsync(m => m.ID == id);
            if (lock_And_Key == null)
            {
                return NotFound();
            }

            return View(lock_And_Key);
        }

        // GET: Lock_And_Key/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Lock_And_Key/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,TotalCopies,InLogic,Sphere")] Lock_And_Key lock_And_Key)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lock_And_Key);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lock_And_Key);
        }

        // GET: Lock_And_Key/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lock_And_Key = await _context.Lock_And_Key.FindAsync(id);
            if (lock_And_Key == null)
            {
                return NotFound();
            }
            return View(lock_And_Key);
        }

        // POST: Lock_And_Key/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,TotalCopies,InLogic,Sphere")] Lock_And_Key lock_And_Key)
        {
            if (id != lock_And_Key.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lock_And_Key);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Lock_And_KeyExists(lock_And_Key.ID))
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
            return View(lock_And_Key);
        }

        // GET: Lock_And_Key/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lock_And_Key = await _context.Lock_And_Key
                .FirstOrDefaultAsync(m => m.ID == id);
            if (lock_And_Key == null)
            {
                return NotFound();
            }

            return View(lock_And_Key);
        }

        // POST: Lock_And_Key/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var lock_And_Key = await _context.Lock_And_Key.FindAsync(id);
            _context.Lock_And_Key.Remove(lock_And_Key);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Lock_And_KeyExists(string id)
        {
            return _context.Lock_And_Key.Any(e => e.ID == id);
        }
    }
}
