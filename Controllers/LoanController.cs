#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using dt191g_moment32.Data;
using dt191g_moment32.Models;

namespace dt191g_moment32.Controllers
{
    public class LoanController : Controller
    {
        private readonly CollectionContext _context;

        public LoanController(CollectionContext context)
        {
            _context = context;
        }

        // GET: Loan
        public async Task<IActionResult> Index()
        {
            // var collectionContext = _context.Loan.Include(c => c.Cd);
            return View(await _context.Loan.Include(c => c.Cd).ToListAsync());
        }

        // GET: Loan/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loan = await _context.Loan
                .FirstOrDefaultAsync(m => m.LoanId == id);
            if (loan == null)
            {
                return NotFound();
            }

            var cds = _context.Cd.ToListAsync().Result;

            return View(loan);
        }

        // GET: Loan/Create
        public IActionResult Create()
        {
            var allCds = _context.Cd.ToListAsync().Result;
            var sortedList = new List<Cd>();
            var loans = _context.Loan.ToListAsync().Result;

            foreach (var cd in allCds)
            {
                if (cd.Loan == null)
                {
                    sortedList.Add(cd);
                }
            }
            
            ViewData["CdId"] = new SelectList(sortedList, "CdId", "Title");
            return View();
        }

        // POST: Loan/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LoanId,Name,Date,CdId")] Loan loan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loan);
        }

        // GET: Loan/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loan = await _context.Loan.FindAsync(id);
            if (loan == null)
            {
                return NotFound();
            }
            
            var allCds = _context.Cd.ToListAsync().Result;
            var sortedList = new List<Cd>();
            var loans = _context.Loan.ToListAsync().Result;

            foreach (var cd in allCds)
            {
                if (cd.Loan == null || cd.CdId == loan.CdId)
                {
                    sortedList.Add(cd);
                }
            }
            
            ViewData["CdId"] = new SelectList(sortedList, "CdId", "Title");
            // ViewData["CdId"] = new SelectList(_context.Cd, "CdId", "Title");
            return View(loan);
        }

        // POST: Loan/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LoanId,Name,Date,CdId")] Loan loan)
        {
            if (id != loan.LoanId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoanExists(loan.LoanId))
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
            return View(loan);
        }

        // GET: Loan/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loan = await _context.Loan
                .FirstOrDefaultAsync(m => m.LoanId == id);
            if (loan == null)
            {
                return NotFound();
            }

            return View(loan);
        }

        // POST: Loan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var loan = await _context.Loan.FindAsync(id);
            _context.Loan.Remove(loan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoanExists(int id)
        {
            return _context.Loan.Any(e => e.LoanId == id);
        }
    }
}
