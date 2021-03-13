using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core
{
    public class BookStoreDbConfig
    {
        public string DATABASE_NAME { get; set; }
        public string BOOKS_COLLECTION_NAME { get; set; }
        public string Connection_String { get; set; }
    }
}
