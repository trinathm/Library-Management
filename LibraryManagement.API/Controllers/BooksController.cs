using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LibraryManagement.API.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpGet("all")]
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book> 
            {
                new Book { Id = 1, Title = "Book1" }, 
                new Book { Id = 2, Title = "Book2" },
            };
        }

        [HttpGet("{bookId:int}")]
        public Book GetBook(int bookId)
        {
            return new Book();
        }

        [HttpPost("category")]
        public int PostBookCategory(BookCategory bookCategory)
        {
            return 0; //// id of newly added category
        }

        [HttpPut("category/{categoryId}")]
        public int PutBookCategory(int categoryId, BookCategory bookCategory)
        {
            return 0; //// id of newly added category
        }

        [HttpPost]
        public int PostBook(Book book)
        {
            return 0; //// id of newly added book
        }

        [HttpPost("bulk")]
        public void PostBulkBooks(List<Book> books)
        {
            /// Need to find some better name or move this import to another controller
        }

        [HttpPut("{bookId}")]
        public bool PutBook(int bookId, Book book)
        {
            return true; //// status whether updated or not, only if necessary
        }

        [HttpDelete("{bookId}")]
        public bool DeleteBook(int bookId)
        {
            return true;
        }
    }
}
