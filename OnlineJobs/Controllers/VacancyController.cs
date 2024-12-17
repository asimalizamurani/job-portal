using Microsoft.AspNetCore.Mvc;
using OnlineJobs.Data;
using OnlineJobs.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace OnlineJobs.Controllers
{
    public class VacancyController : Controller
    {

        public IActionResult ViewVacancy()
        {
                return View();
            }
        public IActionResult CreateVacancy()
        {
            return View();
        }
        public IActionResult EditVacancy()
        {
            return View();
        }

        /* private readonly ApplicationDbContext _context;

         public VacancyController(ApplicationDbContext context)
         {
             _context = context;
         }

         // GET: Vacancy/ViewVacancy/5
         public async Task<IActionResult> ViewVacancy(int? id)
         {
             if (id == null)
             {
                 return NotFound();
             }

             var vacancy = await _context.Vacancies
                 .Include(v => v.CreatedByUser) // Include the user who created the vacancy
                 .FirstOrDefaultAsync(m => m.VacancyId == id);

             if (vacancy == null)
             {
                 return NotFound();
             }

             return View(vacancy);
         }

         // GET: Vacancy/Create
         public IActionResult CreateVacancy()
         {
             return View();
         }

         [HttpPost]
         [ValidateAntiForgeryToken]
         public async Task<IActionResult> CreateVacancy([Bind("Title,Description,Department,PositionsAvailable")] Vacancy vacancy)
         {
             if (ModelState.IsValid)
             {
                 // Set CreatedBy and CreatedAt
                 vacancy.CreatedBy = 1; // Assuming you have a way to get the current user ID
                 vacancy.CreatedAt = DateTime.Now;

                 _context.Add(vacancy);
                 await _context.SaveChangesAsync();
                 return RedirectToAction(nameof(Index)); // Replace "Index" with the appropriate action name
             }
             return View(vacancy);
         }

         // GET: Vacancy/Edit/5
         public async Task<IActionResult> EditVacancy(int? id)
         {
             if (id == null)
             {
                 return NotFound();
             }

             var vacancy = await _context.Vacancies.FindAsync(id);
             if (vacancy == null)
             {
                 return NotFound();
             }
             return View(vacancy);
         }

         // POST: Vacancy/Edit/5
         // To protect from overposting attacks, enable the specific properties you want to bind to.
         // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
         [HttpPost]
         [ValidateAntiForgeryToken]
         public async Task<IActionResult> EditVacancy(int id, [Bind("VacancyId,Title,Description,Department,PositionsAvailable,Status")] Vacancy vacancy)
         {
             if (id != vacancy.VacancyId)
             {
                 return NotFound();
             }

             if (ModelState.IsValid)
             {
                 try
                 {
                     _context.Update(vacancy);
                     await _context.SaveChangesAsync();
                 }
                 catch (DbUpdateConcurrencyException)
                 {
                     if (!VacancyExists(vacancy.VacancyId))
                     {
                         return NotFound();
                     }
                     else
                     {
                         throw;
                     }
                 }
                 return RedirectToAction(nameof(ViewVacancy)); // Replace "Index" with the appropriate action name
             }
             return View(vacancy);
         }

         private bool VacancyExists(int id)
         {
             return _context.Vacancies.Any(e => e.VacancyId == id);
         }*/
    }
}