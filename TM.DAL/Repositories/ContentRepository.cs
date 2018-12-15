using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TM.DAL.DataModels;

namespace TM.DAL.Repositories
{
    public class ContentRepository
    {
        public List<Content> get()
        {
            using (var context = new TMContext())
            {
                var result = context.Content.ToList();

                return result;
            }
        }
    }
}