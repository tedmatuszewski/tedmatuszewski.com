using TM.DTO.Objects;

namespace TM.Domain.Services
{
    public interface ITmService
    {
        string CreateContact(ContactDto dto);

        HomeDto GetHomePage();

        AboutDto GetAboutPage();

    }
}