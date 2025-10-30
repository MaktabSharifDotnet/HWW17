using BookStore.Models.Entities;
using BookStore.Models.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Models.Services
{
    public class CategoryService
    {

        private readonly CategoryRepository categoryRepository = new CategoryRepository();
        public List<Category> GetCategories()
        {
           return categoryRepository.GetCategories();
        }
    }
}
