using BookStore.Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SatoshiTracker2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MongoDbController : ControllerBase
    {
        private readonly IBookServices bookServices;

        public MongoDbController(IBookServices bookServices)
        {
            this.bookServices = bookServices;
        }
        [HttpGet]
        [Route("GetBooks")]
        public IActionResult GetBooks()
        {
            return Ok(bookServices.GetBooks());
        }
        [HttpPost]
        [Route("AddBook")]
        public IActionResult AddBook(Book book)
        {
            bookServices.AddBook(book);
            return Ok(book);
        }
        
        [HttpGet]
        [Route("GetOneBook")]
        public IActionResult GetBook(string id)
        {
            return Ok(bookServices.GetBook(id));
        }
        [HttpDelete]
        [Route("DeleteBook")]
        public IActionResult DeleteBook(string id)
        {
            bookServices.DeleteBook(id);
            return NoContent();
        }
        [HttpPut]
        [Route("UpdateBook")]
        public IActionResult UpdateBook(Book book)
        {
            return Ok(bookServices.UpdateBook(book));
            
        }
    }
}
