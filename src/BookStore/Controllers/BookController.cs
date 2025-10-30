using BookStore.Models.DataBase;
using BookStore.Models.Entities;
using BookStore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        
        public IActionResult Add()
        {
            AppDbContext  _context = new AppDbContext();
            List<Category> categories=_context.Categories.ToList();
            AddBookViewModel addBookviewModel = new AddBookViewModel() 
            {
              Categories = categories
            };
            return View(addBookviewModel);
        }

        [HttpPost]
        public IActionResult Add(AddBookViewModel model)
        {
            string uniqueFileName = null; 
            string imageUrlForDb = null;

            
            string projectRootPath = Directory.GetCurrentDirectory();

           
            string uploadFolder = Path.Combine(projectRootPath, "wwwroot", "images", "books");

          
            uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ImageFile.FileName;

          
            string filePath = Path.Combine(uploadFolder, uniqueFileName);

           
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                model.ImageFile.CopyTo(fileStream);
            }

            imageUrlForDb = "/images/books/" + uniqueFileName;
            model.Book.ImageUrl = imageUrlForDb;
            AppDbContext _context = new AppDbContext();
            _context.Books.Add(model.Book);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");

        }
    }
}
