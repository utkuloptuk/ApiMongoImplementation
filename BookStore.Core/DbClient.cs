using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core
{
    public class DbClient : IDbClient
    {
        private readonly IMongoCollection<Book> books;
        public DbClient(IOptions<BookStoreDbConfig> bookstoreDbConfig)
        {
            var client = new MongoClient(bookstoreDbConfig.Value.Connection_String);
            var database = client.GetDatabase("BookstoreDb");
            books = database.GetCollection<Book>("Books");
        }

        public IMongoCollection<Book> GetBooksCollection() => books;

    }
}
