using Microsoft.AspNetCore.Mvc;
using WebLibrary.Data;
using WebLibrary.Models;

namespace WebLibrary.Controllers
{
    public class SellersController : Controller
    {
        private readonly WebLibraryContext _context;
        public SellersController(WebLibraryContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var list = _context.Seller.ToList();
            //é igual à
            //List<Seller> list = new List<Seller>();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Seller seller)
        {
            seller.Department = _context.Department.First();
            _context.Seller.Add(seller);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
