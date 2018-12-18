using TM.Domain.Entities;

namespace TM.Data.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly TMContext _context;

        public ContactRepository(TMContext context)
        {
            this._context = context;
        }

        public Contact create(Contact domain)
        {
            var result = _context.Contact.Add(domain);

            _context.SaveChanges();

            return result.Entity;
        }
    }
}
