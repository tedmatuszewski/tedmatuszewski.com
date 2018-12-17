using System;
using System.Collections.Generic;
using System.Text;
using TM.BLL.Logic;
using TM.DAL.Repositories;

namespace TM.BLL.Services
{
    public class ContactService
    {
        public string create(ContactLogic logic)
        {
            var repository = new ContactRepository();

            repository.create(logic.toDomain());

            return "Successfully sent a message to Ted. You will recieve a response as soon as possible.";
        }
    }
}