using BookStore.Models.Entities;

namespace BookStore.Models.ViewModels
{
    public class HomeViewModel
    {
        public List<Book> Books { get; set; }
        public List<Category> Categories { get; set; }
    }
}
