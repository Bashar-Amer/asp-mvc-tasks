using Category_Product_Management.Models;
using Microsoft.AspNetCore.Mvc;

namespace Category_Product_Management.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _dbContext;
        public ProductController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Details(int id)
        {
            var product = await _dbContext.Products.FindAsync(id);
            if (product != null)
                return View(product);

            return RedirectToRoute(new { controller = "Category", action = "Index"});
        }
    }
}
