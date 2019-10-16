using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using A1_200382154.Data;
using A1_200382154.Models;

namespace A1_200382154.Controllers
{
    public class FoodShopController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FoodShopController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FoodShop
        public async Task<IActionResult> Index()
        {
            return View(await _context.Food.ToListAsync());
            //Where we can get our list from
            //We can use this like an if statement to filter for certain criteria
        }

        // GET: FoodShop/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) //if we dont find an id, we return "Not Found"
            {
                return NotFound(); //Handle with a 404 Error
            } 

            var food = await _context.Food
                .FirstOrDefaultAsync(m => m.Id == id); //find the first that matches, or give defualt (Null)
            if (food == null)
            {
                return NotFound(); //Handle with 404 Error
            }

            return View(food);
        }

        // GET: FoodShop/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FoodShop/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Price,Name,Description,NutritionalInformation,Weight,Brand,TypeOfAnimalFor")] Food food)
        {
            if (ModelState.IsValid)
            {
                _context.Add(food);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(food);
        }

        // GET: FoodShop/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var food = await _context.Food.FindAsync(id);
            if (food == null)
            {
                return NotFound();
            }
            return View(food);
        }

        // POST: FoodShop/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Price,Name,Description,NutritionalInformation,Weight,Brand,TypeOfAnimalFor")] Food food)
        {
            if (id != food.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(food);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FoodExists(food.Id))
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
            return View(food);
        }

        // GET: FoodShop/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var food = await _context.Food
                .FirstOrDefaultAsync(m => m.Id == id);
            if (food == null)
            {
                return NotFound();
            }

            return View(food);
        }

        // POST: FoodShop/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var food = await _context.Food.FindAsync(id);
            _context.Food.Remove(food);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FoodExists(int id)
        {
            return _context.Food.Any(e => e.Id == id);
        }
    }
}
