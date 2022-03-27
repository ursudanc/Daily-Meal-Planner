using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DMP.Data;
using DMP.Models;

namespace DMP.Controllers
{
    public class Meal_PlansController : Controller
    {
        private readonly DMPContext _context;

        public Meal_PlansController(DMPContext context)
        {
            _context = context;
        }

        // GET: Meal_Plans
        public async Task<IActionResult> Index()
        {
            var dMPContext = _context.Meal_Plans.Include(m => m.Recipe).Include(m => m.User);
            return View(await dMPContext.ToListAsync());
        }

        // GET: Meal_Plans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meal_Plans = await _context.Meal_Plans
                .Include(m => m.Recipe)
                .Include(m => m.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (meal_Plans == null)
            {
                return NotFound();
            }

            return View(meal_Plans);
        }

        // GET: Meal_Plans/Create
        public IActionResult Create()
        {
            ViewData["RecipeId"] = new SelectList(_context.Recipes, "Id", "Description");
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "password");
            return View();
        }

        // POST: Meal_Plans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RecipeId,UserId,MealPlan")] Meal_Plans meal_Plans)
        {
            if (ModelState.IsValid)
            {
                _context.Add(meal_Plans);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RecipeId"] = new SelectList(_context.Recipes, "Id", "Description", meal_Plans.RecipeId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "password", meal_Plans.UserId);
            return View(meal_Plans);
        }

        // GET: Meal_Plans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meal_Plans = await _context.Meal_Plans.FindAsync(id);
            if (meal_Plans == null)
            {
                return NotFound();
            }
            ViewData["RecipeId"] = new SelectList(_context.Recipes, "Id", "Description", meal_Plans.RecipeId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "password", meal_Plans.UserId);
            return View(meal_Plans);
        }

        // POST: Meal_Plans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RecipeId,UserId,MealPlan")] Meal_Plans meal_Plans)
        {
            if (id != meal_Plans.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(meal_Plans);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Meal_PlansExists(meal_Plans.Id))
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
            ViewData["RecipeId"] = new SelectList(_context.Recipes, "Id", "Description", meal_Plans.RecipeId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "password", meal_Plans.UserId);
            return View(meal_Plans);
        }

        // GET: Meal_Plans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meal_Plans = await _context.Meal_Plans
                .Include(m => m.Recipe)
                .Include(m => m.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (meal_Plans == null)
            {
                return NotFound();
            }

            return View(meal_Plans);
        }

        // POST: Meal_Plans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var meal_Plans = await _context.Meal_Plans.FindAsync(id);
            _context.Meal_Plans.Remove(meal_Plans);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Meal_PlansExists(int id)
        {
            return _context.Meal_Plans.Any(e => e.Id == id);
        }
    }
}
