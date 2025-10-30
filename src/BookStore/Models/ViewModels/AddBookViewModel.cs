using BookStore.Models.Entities;

namespace BookStore.Models.ViewModels
{
    public class AddBookViewModel
    {
        public Book Book { get; set; }
        public List<Category> Categories { get; set; }
        public Category Category { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
