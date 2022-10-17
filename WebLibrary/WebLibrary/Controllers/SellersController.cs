using Microsoft.AspNetCore.Mvc;
using WebLibrary.Data;
using WebLibrary.Models;
using WebLibrary.Models.ViewModels;

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
            var viewModel = new SellerFormViewModel();
            viewModel.Departments = _context.Department.ToList();
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Create(Seller seller)
        {
            //seller.Department = _context.Department.First();
            _context.Seller.Add(seller);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var seller = _context.Seller.FirstOrDefault(s => s.Id == id);
            if (seller == null)
            {
                return NotFound(nameof(seller));
            }
            return View(seller);
        }
    }
}
