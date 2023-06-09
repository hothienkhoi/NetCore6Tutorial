﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyWebApiNetCore6.Data;
using MyWebApiNetCore6.Models;

namespace MyWebApiNetCore6.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoreContext _context;
        private readonly IMapper _mapper;

        public BookRepository(BookStoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }
        public bool BookExists(int id)
        {
            var checkBook = _context.Books!.SingleOrDefault(x => x.Id == id);
            if (checkBook != null)
            {
                return true;
            }
            return false;
        }

        public async Task<int> CreateBookAsync(BookModel model)
        {
            var newBook = _mapper.Map<Book>(model);
            _context.Books!.Add(newBook);
            await _context.SaveChangesAsync();
            return newBook.Id;
        }

        public async Task DeleteBookAsync(int id)
        {
            var deleteBook = _context.Books!.SingleOrDefault( x => x.Id == id);
            if (deleteBook != null)
            {
                _context.Books!.Remove(deleteBook);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<BookModel> GetBookByIdAsync(int id)
        {
            var book = await _context.Books!.FindAsync(id);
            return _mapper.Map<BookModel>(book);
        }

        public async Task<List<BookModel>> GetAllBooksAsync()
        {
            var books = await _context.Books!.ToListAsync();
            return _mapper.Map<List<BookModel>>(books);
        }

        public async Task UpdateBookAsync(int id, BookModel model)
        {
            if (id == model.Id)
            {
                var updateBook = _mapper.Map<Book>(model);
                _context.Books!.Update(updateBook);
                await _context.SaveChangesAsync();
            }
        }
    }
}