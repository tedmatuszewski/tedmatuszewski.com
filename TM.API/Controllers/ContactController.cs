using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TM.BLL.Logic;
using TM.BLL.Services;

namespace TM.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : Controller
    {
        private ContactService service = new ContactService();

        [HttpPost]
        public ActionResult<string> Post(ContactLogic logic)
        {
            var response = service.create(logic);

            return response;
        }
    }
}