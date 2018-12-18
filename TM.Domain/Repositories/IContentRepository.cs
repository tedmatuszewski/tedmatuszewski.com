using System.Collections.Generic;
using TM.Domain.Entities;

namespace TM.Data.Repositories
{
    public interface IContentRepository
    {
        List<Content> get();
    }
}