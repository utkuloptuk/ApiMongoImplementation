using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core
{
    public class BookServices : IBookServices
    {
        private readonly IMongoCollection<Book> books;

        public BookServices(IDbClient dbClient)
        {
            books = dbClient.GetBooksCollection();
        }

        public Book AddBook(Book book)
        {
            books.InsertOne(book);
            return book;
        }

        public void DeleteBook(string id)
        {
            books.DeleteOne(book => book.Id == id);
        }

        public Book GetBook(string id)
        {
            return books.Find(b => b.Id == id).First();
        }

        public List<Book> GetBooks()
        {
            return books.Find(book => true).ToList();

        }

        public Book UpdateBook(Book book)
        {
            GetBook(book.Id);
            books.ReplaceOne(b => b.Id == book.Id, book);
            return book;
        }
    }
}
