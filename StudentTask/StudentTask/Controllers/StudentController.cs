using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentTask.Models;

namespace StudentTask.Controllers
{
    public class StudentController :Controller
    {

        private readonly AppDbContext _dbContext;

        public StudentController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }



        public async Task<IActionResult> Index() {
            var data = await _dbContext.Students.ToListAsync();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Student student)
        {
            if (ModelState.IsValid)
            {
                await _dbContext.Students.AddAsync(student);
                await _dbContext.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var student = await _dbContext.Students.FindAsync(id);

            if (student is not null)
                return View(student);
            else
                return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Students.Update(student);
                await _dbContext.SaveChangesAsync();
            }
            
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var student = _dbContext.Students.Find(id);
            if (student is not null)
                return View(student);
            else
                return RedirectToAction("Index");
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteItem(int id)
        {            
            var student = _dbContext.Students.Find(id);
            if (student is not null)
            {
                _dbContext.Students.Remove(student);
                _dbContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}
