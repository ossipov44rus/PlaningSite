using Microsoft.AspNetCore.Mvc;
using ZadachaFinal2.Data;
using ZadachaFinal2.Models;

namespace ZadachaFinal2.Controllers
{
    public class Zad1Controller : Controller
    {
        protected ZadachaDbContext _db;
        public Zad1Controller(ZadachaDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Zadacha1> zad1List = _db.zad1;
            return View(zad1List);
        }
        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Zadacha1 obj)
        {
            if (ModelState.IsValid)
            {
                _db.zad1.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET
        public IActionResult Edit(int? id)
        {
            if(id == null || id < 1) { return NotFound(); }
            var zad1 = _db.zad1.Find(id);
            if (zad1 == null) { return NotFound(); }
            return View(zad1);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Zadacha1 obj)
        {
            if (ModelState.IsValid)
            {
                _db.zad1.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET
        public IActionResult Delete(int? id)
        {
            if (id == null || id < 1) { return NotFound(); }
            var zad1 = _db.zad1.Find(id);
            if (zad1 == null) { return NotFound(); }
            return View(zad1);
        }

        //POST
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            if(id==null || id < 1) { return NotFound(); }
            var obj = _db.zad1.Find(id);
            _db.zad1.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
