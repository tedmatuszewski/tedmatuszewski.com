using System;
using System.Collections.Generic;
using System.Text;
using TM.Domain.Entities;
using TM.DTO.Objects;

namespace TM.Domain.Convertors
{
    public static class ContactConvertor
    {
        public static ContactDto Convert(Contact data)
        {
            return new ContactDto()
            {
                fullname = data.FullName,
                email = data.Email,
                message = data.Message
            };
        }

        public static Contact Convert(ContactDto dto)
        {
            return new Contact()
            {
                Message = dto.message,
                FullName = dto.fullname,
                Email = dto.email
            };
        }
    }
}
