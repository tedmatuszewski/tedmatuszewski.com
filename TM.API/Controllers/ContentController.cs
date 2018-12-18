using Microsoft.AspNetCore.Mvc;
using TM.Domain.Services;
using TM.DTO.Objects;

namespace TM.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContentController : ControllerBase
    {
        private readonly ITmService _service;

        public ContentController(ITmService service)
        {
            _service = service;
        }

        [HttpGet("home")]
        public ActionResult<HomeDto> GetHome()
        {
            var response = _service.GetHomePage();

            return response;
        }

        [HttpGet("about")]
        public ActionResult<AboutDto> GetAbout()
        {
            var response = _service.GetAboutPage();

            return response;
        }
    }
}
