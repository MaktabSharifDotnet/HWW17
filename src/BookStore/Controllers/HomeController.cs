using System.Diagnostics;
using BookStore.Models;
using BookStore.Models.DataBase;
using BookStore.Models.Entities;
using BookStore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;



namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            AppDbContext _context = new AppDbContext();
            List<Book> books  = _context.Books.ToList();
            List<Category> categories = _context.Categories.ToList();
            HomeViewModel homeViewModel = new HomeViewModel() 
            {
              Books = books,
              Categories = categories
            };
            return View(homeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
