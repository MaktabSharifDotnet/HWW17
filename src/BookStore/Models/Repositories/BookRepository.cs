using BookStore.Models.DataBase;
using BookStore.Models.Entities;
using static System.Reflection.Metadata.BlobBuilder;

namespace BookStore.Models.Repositories
{
    public class BookRepository
    {
        private readonly AppDbContext _context;
        public BookRepository()
        {
            _context = new AppDbContext();
        }
        public List<Book> GetBooks()
        {
           return _context.Books.OrderByDescending(b => b.Id)
                .Take(5)
                .ToList();
        }
        public void Create (Book book) 
        {
          _context.Books.Add(book); 
           _context.SaveChanges();
        }
    }
}
