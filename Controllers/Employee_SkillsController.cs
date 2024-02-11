using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebDev_CourseWork1.Models;

namespace WebDev_CourseWork1.Controllers
{
    public class Employee_SkillsController : Controller
    {
        private readonly OrganisationContext _context;

        public Employee_SkillsController(OrganisationContext context)
        {
            _context = context;
        }

        // GET: Employee_Skills
        public async Task<IActionResult> Index()
        {
            return View(await _context.Employee_Skills.ToListAsync());
        }

        // GET: Employee_Skills/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee_Skills = await _context.Employee_Skills
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee_Skills == null)
            {
                return NotFound();
            }

            return View(employee_Skills);
        }

        // GET: Employee_Skills/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employee_Skills/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Employee_Skills employee_Skills)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employee_Skills);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee_Skills);
        }

        // GET: Employee_Skills/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee_Skills = await _context.Employee_Skills.FindAsync(id);
            if (employee_Skills == null)
            {
                return NotFound();
            }
            return View(employee_Skills);
        }

        // POST: Employee_Skills/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("Id,Name")] Employee_Skills employee_Skills)
        {
            if (id != employee_Skills.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee_Skills);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Employee_SkillsExists(employee_Skills.Id))
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
            return View(employee_Skills);
        }

        // GET: Employee_Skills/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee_Skills = await _context.Employee_Skills
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee_Skills == null)
            {
                return NotFound();
            }

            return View(employee_Skills);
        }

        // POST: Employee_Skills/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var employee_Skills = await _context.Employee_Skills.FindAsync(id);
            if (employee_Skills != null)
            {
                _context.Employee_Skills.Remove(employee_Skills);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Employee_SkillsExists(int? id)
        {
            return _context.Employee_Skills.Any(e => e.Id == id);
        }
    }
}
