using System;
using System.Collections.Generic;
using System.Text;

namespace UserTicketService
{
    public interface IBookRepository
    {
        IEnumerable<Book> FindAll();
    }

}
