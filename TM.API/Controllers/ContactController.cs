using Microsoft.AspNetCore.Mvc;
using TM.Domain.Services;
using TM.DTO.Objects;

namespace TM.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : Controller
    {
        private readonly ITmService _service;

        public ContactController(ITmService service)
        {
            _service = service;
        }

        [HttpPost]
        public ActionResult<string> Post(ContactDto logic)
        {
            var response = _service.CreateContact(logic);

            return response;
        }
    }
}