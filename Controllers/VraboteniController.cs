using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Employees.Models;

namespace Employees.Controllers
{
    public class VraboteniController : Controller
    {
        private readonly EmployeesDbContext _context;

        public VraboteniController(EmployeesDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Vraboteni.ToListAsync());
        }

        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Vraboteni());
            else
                return View(_context.Vraboteni.Find(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("VrabotenId,Ime,Prezime,Plata,OddelId")] Vraboteni vraboten)
        {
            if (ModelState.IsValid)
            {
                if (vraboten.VrabotenId == 0)
                    _context.Add(vraboten);
                else
                    _context.Update(vraboten);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vraboten);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vraboten = await _context.Vraboteni.FindAsync(id);
            _context.Vraboteni.Remove(vraboten);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
