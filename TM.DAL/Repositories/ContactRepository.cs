using System;
using System.Collections.Generic;
using System.Text;
using TM.DAL.DataModels;

namespace TM.DAL.Repositories
{
    public class ContactRepository
    {
        public Contact create(Contact domain)
        {
            using (var context = new TMContext())
            {
                var result = context.Contact.Add(domain);

                context.SaveChanges();

                return result.Entity;
            }
        }
    }
}
