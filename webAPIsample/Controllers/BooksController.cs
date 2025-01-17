﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webAPIsample.Data.Services;
using webAPIsample.Data.ViewModels;

namespace webAPIsample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public BookService _bookservice;
        public BooksController(BookService bookService)
        {
            _bookservice = bookService;
        }
        [HttpPost("add-book")]
        public IActionResult AddBook([FromBody]BookVM book)
        {
            _bookservice.AddBook(book);
            return Ok();
        }

        [HttpGet("get-all-books")]
        public IActionResult GetAllBooks() 
        {
            var allBooks = _bookservice.GetAllBooks(); 
            return Ok(allBooks);
        }
        [HttpGet("get-book-by-id/{id}")]
        public IActionResult GetBookById(int id)
        {
            var book = _bookservice.GetBookById(id);
            return Ok(book);
        }
        [HttpPut("update-book-by-id/{id}")]
        public IActionResult UpdateBook(int id, [FromBody]BookVM book)
        {
            var updateBook = _bookservice.UpdateBookById(id, book);
            return Ok(updateBook);

        }
    }
}
