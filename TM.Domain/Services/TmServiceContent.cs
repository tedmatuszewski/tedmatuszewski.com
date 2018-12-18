using TM.Domain.Convertors;
using TM.DTO.Objects;

namespace TM.Domain.Services
{
    public partial class TmService
    {
        public HomeDto GetHomePage()
        {
            var data = _contentRepository.get().ConvertAll(c => ContentConvertor.Convert(c));
            var response = new HomeDto(data);

            return response;
        }

        public AboutDto GetAboutPage()
        {
            var data = _contentRepository.get().ConvertAll(c => ContentConvertor.Convert(c));
            var response = new AboutDto(data);

            return response;
        }
    }
}