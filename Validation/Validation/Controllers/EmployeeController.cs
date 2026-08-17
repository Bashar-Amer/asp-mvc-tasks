
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Validation.Models;
using Validation.Data;

public class EmployeeController : Controller
{
    private readonly AppDbContext _context;

    public EmployeeController(AppDbContext context) => _context = context;

    public async Task<IActionResult> Index() 
        => View(await _context.Employee.ToListAsync());

    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
            return NotFound();
        
        var employee = await _context.Employee.FirstOrDefaultAsync(m => m.Id == id);

        if (employee == null)
            return NotFound();

        return View(employee);
    }

  
    public IActionResult Create() 
        => View();

    [HttpPost]
    public async Task<IActionResult> Create(Employee employee)
    {
        if (ModelState.IsValid)
        {
            _context.Add(employee);
            await _context.SaveChangesAsync();
            TempData["Success"] = "User created successfully!";
            return RedirectToAction("Index");
        }
        TempData["Error"] = "Invalid data!";
        return View(employee);
    }

    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            TempData["Error"] = "User not found";
            return NotFound();
        }
        
        var employee = await _context.Employee.FirstOrDefaultAsync(m => m.Id == id);

        if (employee == null)
        {
            TempData["Error"] = "User not found";
            return NotFound();
        }
            

        return View(employee);
    }

    [HttpPost, ActionName("Delete")]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var employee = await _context.Employee.FindAsync(id);
        if (employee != null)
        {
            _context.Employee.Remove(employee);
            await _context.SaveChangesAsync();
            TempData["Success"] = "User deleted successfully!";
        }
        else
        {
            TempData["Error"] = "User not found";
        }
            
        return RedirectToAction("Index");
    }
}
