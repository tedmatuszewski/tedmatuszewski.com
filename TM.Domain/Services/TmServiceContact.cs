using System;
using System.Collections.Generic;
using System.Text;
using TM.Domain.Convertors;
using TM.DTO;

namespace TM.Domain.Services
{
    public partial class TmService
    {
        public string CreateContact(ContactDto dto)
        {
            var data = _contactRepository.create(ContactConvertor.Convert(dto));

            return "Successfully sent a message to Ted. You will recieve a response as soon as possible.";
        }
    }
}
