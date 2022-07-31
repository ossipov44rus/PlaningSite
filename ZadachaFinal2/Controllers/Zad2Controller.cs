using Microsoft.AspNetCore.Mvc;
using ZadachaFinal2.Data;
using ZadachaFinal2.Models;

namespace ZadachaFinal2.Controllers
{
    public class Zad2Controller : Controller
    {
        protected ZadachaDbContext _db;
        public Zad2Controller(ZadachaDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Zadacha2> zad2List = _db.zad2;
            return View(zad2List);
        }

        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Zadacha2 obj)
        {
            if (ModelState.IsValid)
            {
                _db.zad2.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id < 1) { return NotFound(); }
            var zad2 = _db.zad2.Find(id);
            if (zad2 == null) { return NotFound(); }
            return View(zad2);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Zadacha2 obj)
        {
            if (ModelState.IsValid)
            {
                _db.zad2.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }


        //GET
        public IActionResult Delete(int? id)
        {
            if (id == null || id < 1) { return NotFound(); }
            var zad2 = _db.zad2.Find(id);
            if (zad2 == null) { return NotFound(); }
            return View(zad2);
        }

        //POST
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            if(id == null || id < 1) { return NotFound(); }
            var obj = _db.zad2.Find(id);
            _db.zad2.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");  
            
        }
    }
}
