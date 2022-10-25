using Microsoft.AspNetCore.Mvc;
using WebLibrary.Data;
using WebLibrary.Models;
using WebLibrary.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using NuGet.Protocol.Plugins;

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
            //var list = _context.Seller.Include(d => d.Department).ToList();
            //é igual à
            //List<Seller> list = new List<Seller>();
            //var list = _context.Seller.Include(s => s.Department).Where(s => s.Name.StartsWith("A")).ToList();
            //var list = _context.Seller.Include(s => s.Department).Where(s => s.Name.EndsWith("a")).ToList();
            //var list = _context.Seller.Include(s => s.Department).Where(s => s.Name.Contains("Azenha")).ToList();
            //var list = _context.Seller.Include(s => s.Department).Where(s => s.Name == "Azenha").ToList();
            //var list = _context.Seller.Include(s => s.Department).Where(s => s.Salary >2000).ToList();
            //var list = _context.Seller.Include(s => s.Department).Where(s => s.Name.Contains("Vendedor")).OrderBy(s => s.Name).ThenBy(s => s.Salary).ToList();
            var list = _context.Seller.Include(s => s.Department).Where(s => s.BirthDate > new DateTime(1998, 1, 1)).OrderBy(s => s.Name).ThenBy(s => s.Salary).ToList();
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

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Seller seller = _context.Seller.Include(s => s.Department).FirstOrDefault(s => s.Id == id);
            if(seller == null)
            {
                return NotFound();
            }
            var viewModel = new SellerFormViewModel();
            viewModel.Seller = seller;
            viewModel.Departments = _context.Department.ToArray();
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Edit(Seller seller)
        {
            _context.Seller.Update(seller);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
