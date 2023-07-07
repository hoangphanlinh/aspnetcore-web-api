using my_books.Data.Models;
using my_books.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Data.Services
{
    public class BooksService
    {
        private AppDbContext _context;
        public BooksService(AppDbContext context)
        {
            _context = context;
        }
        public void AddBook(BooksVM book)
        {
            var _book = new Book()
            {
                Title = book.Title,
                Description = book.Description,
                IsRead = book.IsRead,
                DateRead = book.IsRead ? book.DateRead : null,
                Rate = book.IsRead ? book.Rate :null,
                Genre = book.Genre,
                Author = book.Author,
                CoverUrl = book.CoverUrl,
                DateAdded = DateTime.Now

            };
            _context.Books.Add(_book);
            _context.SaveChanges();
        }
        public List<Book> GetAllBooks()
        {
            return _context.Books.ToList();
        }
        public Book GetBookById(int bookId)
        {
            return _context.Books.FirstOrDefault(n=>n.Id == bookId);
        }

        public Book UpdateBookById(BooksVM book)
        {
            if(book==null || book.Id == 0)
            {
                if(book == null)
                {
                    return BadRequest("Model data is valid");
                }
                else if(book.Id == 0)
                {
                    return BadRequest($"Book Id{book.Id} is valid");
                }
            }

            try
            {
                var _book = _context.Books.Find(book.Id);
                if(_book == null)
                {
                    return NotFound($"Book not found with id{book.Id}");
                }
                else
                {
                    _book.Title = book.Title;
                    _book.Description = book.Description;
                    _book.IsRead = book.IsRead;
                    _book.DateRead = book.IsRead ? book.DateRead : null;
                    _book.Rate = book.IsRead ? book.Rate : null;
                    _book.Genre = book.Genre;
                    _book.Author = book.Author;
                    _book.CoverUrl = book.CoverUrl;

                    _context.SaveChanges();
                    return _book;
                }
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        private Book NotFound(string v)
        {
            throw new NotImplementedException();
        }

        private Book BadRequest(string v)
        {
            throw new NotImplementedException();
        }

        public void DeleteBookById(int bookId)
        {
            var _book = _context.Books.Find(bookId);
            if(_book != null)
            {
                _context.Books.Remove(_book);
                _context.SaveChanges();
            }
        }

    }
}
