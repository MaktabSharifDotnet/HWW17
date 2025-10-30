using System.Diagnostics;
using BookStore.Models;
using BookStore.Models.DataBase;
using BookStore.Models.Entities;
using BookStore.Models.Services;
using BookStore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;



namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly BookService bookService= new BookService();
        
        private readonly CategoryService categoryService= new CategoryService();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            List<Book> books = bookService.GetBooks();
         
            List<Category> categories = categoryService.GetCategories();
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
