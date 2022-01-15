using System;
using System.Collections.Generic;
using System.Text;

namespace UserTicketService
{
    public class BookRepository : IBookRepository
    {
        public IEnumerable<Book> FindAll()
        {
            return null;
        }
    }
}
