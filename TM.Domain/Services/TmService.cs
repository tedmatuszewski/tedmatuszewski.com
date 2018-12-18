using TM.Data.Repositories;

namespace TM.Domain.Services
{
    public partial class TmService : ITmService
    {
        private readonly IContentRepository _contentRepository;
        private readonly IContactRepository _contactRepository;

        public TmService()
        {
        }

        public TmService(IContentRepository contentRepository,
            IContactRepository contactRepository
        )
        {
            _contentRepository = contentRepository;
            _contactRepository = contactRepository;
        }
    }
}