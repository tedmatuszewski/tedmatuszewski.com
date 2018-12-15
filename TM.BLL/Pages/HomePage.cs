using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TM.BLL.Logic;

namespace TM.BLL.Pages
{
    public class HomePage
    {
        public HomePage(List<ContentLogic> contents)
        {
            var intro = contents.SingleOrDefault(c => c.Type == "Introduction");

            this.Quotes = contents.Where(c => c.Type == "Quote").ToList();
            this.Identity = contents.Where(c => c.Type == "Identity").ToList();
            this.IntroductionHeader = intro?.Header;
            this.IntroductionBody = intro?.Value;
        }

        public List<ContentLogic> Quotes { get; private set; }

        public string IntroductionHeader { get; private set; }

        public List<ContentLogic> Identity { get; private set; }

        public object IntroductionBody { get; private set; }
    }
}