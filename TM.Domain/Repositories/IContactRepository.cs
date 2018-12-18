using TM.Domain.Entities;

namespace TM.Data.Repositories
{
    public interface IContactRepository
    {
        Contact create(Contact domain);
    }
}