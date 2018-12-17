using System;
using System.Collections.Generic;

namespace TM.DAL.DataModels
{
    public partial class Contact
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; }
    }
}
