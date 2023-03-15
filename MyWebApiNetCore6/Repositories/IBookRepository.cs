using MyWebApiNetCore6.Models;

namespace MyWebApiNetCore6.Repositories
{
    public interface IBookRepository
    {
        public Task<List<BookModel>> GetAllBooksAsync();
        public Task<BookModel> GetBookByIdAsync(int id);
        public Task UpdateBookAsync(int id, BookModel model);
        public Task<int> CreateBookAsync(BookModel model);
        public Task DeleteBookAsync(int id);
        public bool BookExists(int id);
    }
}
