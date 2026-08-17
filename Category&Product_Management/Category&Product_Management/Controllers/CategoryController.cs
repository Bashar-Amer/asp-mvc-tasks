using Category_Product_Management.DTOs;
using Category_Product_Management.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;



namespace Category_Product_Management.Controllers
{
    public class CategoryController : Controller
    {

        private readonly AppDbContext _dbContext;
        public CategoryController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IActionResult> Index()
        {
            var categories = await _dbContext.Categories.Select(c =>
                new CategoryDTO
                {
                    Id = c.Id,
                    Name = c.Name,
                    ImagePath = c.ImagePath,
                    ProductIds = c.Products.Select(p=>p.Id).ToArray()
                }
            ).ToArrayAsync();

            return View(categories);
        }

        public async Task<IActionResult> Products(int id)
        {
            var category = await _dbContext.Categories.FindAsync(id);
            if(category != null)
            {
                await _dbContext.Entry(category).Collection(c => c.Products).LoadAsync();
                return View(category.Products);
            }

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
