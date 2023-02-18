using Microsoft.AspNetCore.Mvc;
using My_Book.Data.Model;
using My_Book.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace My_Book.Data.Services
{
    public class BookServices
    {
        private BookContext _context;
        public BookServices(BookContext context)
        {
            _context = context;
        }

        

        public void AddBook(BookVM book)
        {
            var _book = new Book()
            {
                Title = book.Title,
                IsRead = book.IsRead,

                CoverUrl = book.CoverUrl,
                Genre = book.Genre,
                Author = book.Author,



            };


            _context.books.Add(_book);
            _context.SaveChanges();
               


        }

        public List<Book> GetAllBooks() => _context.books.ToList();
        public Book GetABookById(int bookId) => _context.books.FirstOrDefault(n=>n.Id==bookId);


    }
}
