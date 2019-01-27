using System.Collections.Generic;
using System.Linq;
using TM.Domain.Entities;

namespace TM.Data.Repositories
{
    public class ContentRepository : IContentRepository
    {
        private readonly TMContext _context;

        public ContentRepository(TMContext context)
        {
            this._context = context;
        }

        public List<Content> get()
        {
            var result = _context.Content.ToList();

            return result;
        }

        public Content create(Content domain)
        {
            var d =_context.Content.Add(domain);

            this._context.SaveChanges();

            return d.Entity;
        }
    }
}