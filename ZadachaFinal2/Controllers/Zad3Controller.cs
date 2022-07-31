using Microsoft.AspNetCore.Mvc;
using ZadachaFinal2.Data;
using ZadachaFinal2.Models;

namespace ZadachaFinal2.Controllers
{
    public class Zad3Controller : Controller
    {
        protected ZadachaDbContext _db;
        public Zad3Controller(ZadachaDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Zadacha3> zad3List = _db.zad3;
            return View(zad3List);
        }
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Zadacha3 obj)
        {
            if (ModelState.IsValid)
            {
                _db.zad3.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id < 1) { return NotFound(); }
            var zad3 = _db.zad3.Find(id);
            if (zad3 == null) { return NotFound(); }
            return View(zad3);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Zadacha3 obj)
        {
            if (ModelState.IsValid)
            {
                _db.zad3.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET
        public IActionResult Delete(int? id)
        {
            if (id == null || id < 1) { return NotFound(); }
            var zad3 = _db.zad3.Find(id);
            if (zad3 == null) { return NotFound(); }
            return View(zad3);
        }

        //POST
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            if(id == null || id < 1) { return NotFound(); }
            var obj = _db.zad3.Find(id);
            _db.zad3.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}