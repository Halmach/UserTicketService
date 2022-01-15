using System;
using System.Collections.Generic;
using System.Text;

namespace UserTicketService
{
    public interface ITicketService
    {
        int GetTicketPrice(int ticketId);
    }
}
