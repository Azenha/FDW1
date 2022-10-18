using Microsoft.AspNetCore.Mvc;
using WebLibrary.Data;
using WebLibrary.Models;
using WebLibrary.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Linq;

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
            var list = _context.Seller.Include(d => d.Department).ToList();
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
            var seller = _context.Seller.Include(d => d.Department).FirstOrDefault(s => s.Id == id);
            if (seller == null)
            {
                return NotFound(nameof(seller));
            }
            return View(seller);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var seller = _context.Seller.Include(d => d.Department).FirstOrDefault(s => s.Id == id);
            if (seller == null)
            {
                return NotFound();
            }
            return View(seller);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var seller = _context.Seller.Find(id);
            if (seller == null)
            {
                return NotFound();
            }
            _context.Seller.Remove(seller);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
