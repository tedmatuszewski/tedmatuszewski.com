using System.Collections.Generic;
using System.Linq;

namespace TM.DTO.Objects
{
    public class HomeDto
    {
        public HomeDto(List<ContentDto> contents)
        {
            var intro = contents.SingleOrDefault(c => c.Type == "Introduction");

            this.Quotes = contents.Where(c => c.Type == "Quote").ToList();
            this.Identity = contents.Where(c => c.Type == "Identity").ToList();
            this.IntroductionHeader = intro?.Header;
            this.IntroductionBody = intro?.Value;
        }

        public List<ContentDto> Quotes { get; private set; }

        public string IntroductionHeader { get; private set; }

        public List<ContentDto> Identity { get; private set; }

        public object IntroductionBody { get; private set; }
    }
}