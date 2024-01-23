using Contracts;
using Entities;

namespace Data
{
    public class InMemoryDatabase : IDatabase
    {
        private static List<Ticket> _tickets = new List<Ticket>();
        
        public List<Ticket> GetTickets()
        {
            return _tickets;
        }

        public int AddTicket(Ticket model)
        {
            model.Id = 1;
            if (_tickets.Any())
                model.Id = _tickets.Max(s => s.Id) + 1;
            _tickets.Add(model);
            return model.Id;
        }
    }
}
