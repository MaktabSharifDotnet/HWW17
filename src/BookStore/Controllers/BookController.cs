using BookStore.Models.DataBase;
using BookStore.Models.Entities;
using BookStore.Models.Services;
using BookStore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly CategoryService categoryService = new CategoryService();
        private readonly BookService bookService = new BookService();
        public IActionResult Add()
        {
           
            List<Category> categories= categoryService.GetCategories();
            AddBookViewModel addBookviewModel = new AddBookViewModel() 
            {
              Categories = categories
            };
            return View(addBookviewModel);
        }

        [HttpPost]
        public IActionResult Add(AddBookViewModel model)
        {
            bookService.Create(model);
            return RedirectToAction("Index", "Home");

        }
    }
}
