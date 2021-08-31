using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BartenderMVC.Data;
using System.Diagnostics;
using BartenderMVC.Models;

namespace BartenderMVC.Controllers
{
    public class CocktailsController : Controller
    {
        private readonly BartenderMVCContext _context;

        public CocktailsController(BartenderMVCContext context)
        {
            _context = context;
        }



        // GET: Cocktails
        public async Task<IActionResult> Index()
        {

            return View(await _context.Cocktail.ToListAsync());
        }

        // POST: Cocktails
        [HttpPost]
        public async Task<IActionResult> Index(string cocktail)
        {

            Queue queue = new Queue(cocktail);
            _context.Queue.Add(queue);
            _context.SaveChanges();

            return View(await _context.Cocktail.ToListAsync());
        }

        // GET: OrderQueue
        public async Task<ViewResult> OrderQueue()
        {
            
            return View(await _context.Queue.ToListAsync());
        }

        // POST: OrderQueue
        [HttpPost]
        public async Task<ViewResult> OrderQueue(int[] orders)
        {
            foreach(var order in orders)
            {
                Console.WriteLine(order + "yep");
                _context.Queue.Find(order).Completed = true;
                _context.SaveChanges();
            }
            return View(await _context.Queue.ToListAsync());
        }

        public IActionResult Home()
        {
            return RedirectToAction("Index", "Home");
        }




    }
}
