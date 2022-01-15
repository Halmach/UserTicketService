using System;
using System.Collections.Generic;
using System.Text;

namespace UserTicketService
{
    public interface IUserRepository
    {
        IEnumerable<User> FindAll();
    }
}
