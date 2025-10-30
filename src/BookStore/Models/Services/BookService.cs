using BookStore.Models.Entities;
using BookStore.Models.Repositories;
using BookStore.Models.ViewModels;
using HW17_Group1.Services;

namespace BookStore.Models.Services
{
    public class BookService
    {
        private readonly BookRepository _bookRepository;
        private readonly FileService fileService = new FileService() ;
        public BookService() 
        {
            _bookRepository = new BookRepository();
        }
        public List<Book> GetBooks() 
        {
          return  _bookRepository.GetBooks();
        }
        public void Create(AddBookViewModel model) 
        {
            model.Book.ImageUrl=fileService.Upload(model.ImageFile);
            _bookRepository.Create(model.Book);
        }
    }
}
