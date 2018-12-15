using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TM.BLL.Logic
{
    public class ContentLogic
    {
        public ContentLogic(DAL.DataModels.Content domain)
        {
            Id = domain.Id;
            Type = domain.Type;
            Value = domain.Value;
            Header = domain.Header;
            Subheader = domain.Subheader;
            Order = domain.Order;
            Year = domain.Year;
            IsDeleted = domain.IsDeleted;
        }

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