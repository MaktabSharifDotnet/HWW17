using BookStore.Models.DataBase;
using BookStore.Models.Entities;

namespace BookStore.Models.Repositories
{
    public class CategoryRepository
    {
        private readonly AppDbContext _context = new AppDbContext();

        public List<Category> GetCategories() 
        {

            return _context.Categories.ToList();
        }
    }
}
