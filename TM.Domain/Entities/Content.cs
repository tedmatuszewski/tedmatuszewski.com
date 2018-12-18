using System;
using System.Collections.Generic;

namespace TM.Domain.Entities
{
    public partial class Content
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public string Header { get; set; }
        public string Subheader { get; set; }
        public int? Order { get; set; }
        public int? Year { get; set; }
        public bool IsDeleted { get; set; }
    }
}
