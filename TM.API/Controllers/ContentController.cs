using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TM.Domain.Services;
using TM.DTO;

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

        [HttpGet]
        public ActionResult<List<ContentDto>> Get()
        {
            var response = _service.GetAllContent();

            return response;
        }

        [HttpPost]
        public ActionResult<ContentDto> Post(ContentDto dto)
        {
            var response =_service.CreateContent(dto);

            return response;
        }
    }
}
