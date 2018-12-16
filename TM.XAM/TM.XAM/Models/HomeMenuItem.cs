using System;
using System.Collections.Generic;
using System.Text;

namespace TM.XAM.Models
{
    public enum MenuItemType
    {
        Home,
        Resume,
        Contact
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
