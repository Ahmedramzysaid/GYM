using GYM.GymDbContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GYM.Controllers
{
    public class PlanController(GYMDbContext _dbcontext) : Controller
    {
        public  async Task<IActionResult> Index()
        {
            var result = await _dbcontext.Plans.ToListAsync();
            return View(result);
        }
        public async Task<IActionResult> Details(int id)
        {
            var result = await _dbcontext.Plans.FirstOrDefaultAsync(p => p.Id == id);
            if (result == null)
            {
                return RedirectToAction("Index");
            }
            return View(result);
        }

        }
}
