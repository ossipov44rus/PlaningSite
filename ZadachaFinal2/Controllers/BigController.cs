using Microsoft.AspNetCore.Mvc;
using ZadachaFinal2.Data;

namespace ZadachaFinal2.Controllers
{
    public class BigController : Controller
    {
        protected ZadachaDbContext _db;
        public BigController(ZadachaDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var i = _db;
            return View(i);
        }
    }
}
