using System.Collections.Generic;
using TM.DTO;

namespace TM.Domain.Services
{
    public interface ITmService
    {
        string CreateContact(ContactDto dto);

        HomeDto GetHomePage();

        AboutDto GetAboutPage();

        List<ContentDto> GetAllContent();

        ContentDto CreateContent(ContentDto dto);
    }
}