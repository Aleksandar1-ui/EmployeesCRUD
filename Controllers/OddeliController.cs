using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Employees.Models;

namespace Employees.Controllers
{
    public class OddeliController : Controller
    {
        private readonly EmployeesDbContext _context;

        public OddeliController(EmployeesDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Oddeli.ToListAsync());
        }

        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Oddeli());
            else
                return View(_context.Oddeli.Find(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("OddelId,ImeOddel,BrojVraboteni")] Oddeli oddel)
        {
            if (ModelState.IsValid)
            {
                if (oddel.OddelId == 0)
                    _context.Add(oddel);
                else
                    _context.Update(oddel);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(oddel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var oddel = await _context.Oddeli.FindAsync(id);
            _context.Oddeli.Remove(oddel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}

