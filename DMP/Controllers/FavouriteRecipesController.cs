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
    public class FavouriteRecipesController : Controller
    {
        private readonly DMPContext _context;

        public FavouriteRecipesController(DMPContext context)
        {
            _context = context;
        }

        // GET: FavouriteRecipes
        public async Task<IActionResult> Index()
        {
            var dMPContext = _context.FavouriteRecipes.Include(f => f.Recipe).Include(f => f.User);
            return View(await dMPContext.ToListAsync());
        }

        // GET: FavouriteRecipes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var favouriteRecipes = await _context.FavouriteRecipes
                .Include(f => f.Recipe)
                .Include(f => f.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (favouriteRecipes == null)
            {
                return NotFound();
            }

            return View(favouriteRecipes);
        }

        // GET: FavouriteRecipes/Create
        public IActionResult Create()
        {
            ViewData["RecipeId"] = new SelectList(_context.Recipes, "Id", "Description");
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "password");
            return View();
        }

        // POST: FavouriteRecipes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RecipeId,UserId")] FavouriteRecipes favouriteRecipes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(favouriteRecipes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RecipeId"] = new SelectList(_context.Recipes, "Id", "Description", favouriteRecipes.RecipeId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "password", favouriteRecipes.UserId);
            return View(favouriteRecipes);
        }

        // GET: FavouriteRecipes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var favouriteRecipes = await _context.FavouriteRecipes.FindAsync(id);
            if (favouriteRecipes == null)
            {
                return NotFound();
            }
            ViewData["RecipeId"] = new SelectList(_context.Recipes, "Id", "Description", favouriteRecipes.RecipeId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "password", favouriteRecipes.UserId);
            return View(favouriteRecipes);
        }

        // POST: FavouriteRecipes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RecipeId,UserId")] FavouriteRecipes favouriteRecipes)
        {
            if (id != favouriteRecipes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(favouriteRecipes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FavouriteRecipesExists(favouriteRecipes.Id))
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
            ViewData["RecipeId"] = new SelectList(_context.Recipes, "Id", "Description", favouriteRecipes.RecipeId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "password", favouriteRecipes.UserId);
            return View(favouriteRecipes);
        }

        // GET: FavouriteRecipes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var favouriteRecipes = await _context.FavouriteRecipes
                .Include(f => f.Recipe)
                .Include(f => f.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (favouriteRecipes == null)
            {
                return NotFound();
            }

            return View(favouriteRecipes);
        }

        // POST: FavouriteRecipes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var favouriteRecipes = await _context.FavouriteRecipes.FindAsync(id);
            _context.FavouriteRecipes.Remove(favouriteRecipes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FavouriteRecipesExists(int id)
        {
            return _context.FavouriteRecipes.Any(e => e.Id == id);
        }
    }
}
