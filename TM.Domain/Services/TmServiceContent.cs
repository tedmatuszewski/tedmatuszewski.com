using System.Collections.Generic;
using TM.Domain.Convertors;
using TM.DTO;

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

        public List<ContentDto> GetAllContent()
        {
            var data = _contentRepository.get().ConvertAll(c => ContentConvertor.Convert(c));

            return data;
        }
    }
}