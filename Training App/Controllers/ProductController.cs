using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Training_App.Models;
using Microsoft.EntityFrameworkCore;

namespace Training_App.Controllers
{
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("main")]
        public IActionResult Index()
        {
            try
            {
                // Retrieve products from the database
                var products = _context.Products.ToList();
                return View(products);
            }
            catch (Exception ex)
            {
                // Log any errors
                Console.WriteLine($"Error retrieving products: {ex.Message}");
                // Optionally, you can return an error view or redirect to an error page
                return StatusCode(500, "An error occurred while retrieving products.");
            }
        }

        [HttpGet("test")]
        public string test()
        {
            return "This is a test!";
        }

        [HttpGet("Create")]
        public IActionResult Create(Product product)
        {
            // Create a new instance of Product to pass to the view
            var newProduct = new Product();
            return View(newProduct);
        }

        [HttpPost("Create")]
        [ValidateAntiForgeryToken]
        public IActionResult CreateConfirmed([Bind("Name", "Price")] Product product)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // Add the new product to the context and save changes
                    _context.Products.Add(product);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    // Log any errors
                    Console.WriteLine($"Error creating product: {ex.Message}");
                    ModelState.AddModelError("", "An error occurred while creating the product.");
                    return View("Create", product);
                }
            }
            return View("Create", product);
        }


    }
}
