using Microsoft.AspNetCore.Mvc;
using todo_app.Data;
using todo_app.Models;

namespace todo_app.Controllers
{
    public class AssigmentController : Controller
    {
        private readonly AppDbContext _db;

        public AssigmentController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Models.Assigment> assigments = _db.Assigments;
            return View(assigments);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Assigment obj)
        {
       
            if (ModelState.IsValid)
            {
                _db.Assigments.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Category created successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}

