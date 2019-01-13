using System;
using System.Collections.Generic;
using System.Text;

namespace TM.DTO
{
    public class ContentDto
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