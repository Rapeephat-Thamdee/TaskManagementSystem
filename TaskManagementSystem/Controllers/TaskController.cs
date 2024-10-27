using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManagementSystem.Models;


namespace TaskManagementSystem.Controllers
{
    public class TaskController : Controller
    {
        private readonly ApplicationDBContext _Db;
        public TaskController(ApplicationDBContext db) { _Db = db; }


        public async Task<IActionResult> Index()
        {
            // ดึงข้อมูลงานทั้งหมดจากฐานข้อมูล
            var tasks = await _Db.Tasks.ToListAsync();
            return View(tasks);
        }

        public IActionResult Create() { return View(); }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Models.Task task)
        {
            if (ModelState.IsValid)
            {
                
                _Db.Add(task);
                await _Db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(task);
        }


        public IActionResult Edit(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var obj = _Db.Tasks.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Models.Task obj)
        {
            if (ModelState.IsValid)
            {
                _Db.Tasks.Update(obj);
                _Db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }


        public IActionResult Delete(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }

            var obj = _Db.Tasks.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }
            _Db.Tasks.Remove(obj);
            _Db.SaveChanges();
            return RedirectToAction("Index");
        }

    }

}
