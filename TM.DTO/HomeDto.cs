using System.Collections.Generic;
using System.Linq;

namespace TM.DTO
{
    public class HomeDto
    {
        public HomeDto()
        {

        }

        public HomeDto(List<ContentDto> contents)
        {
            if(contents == null)
            {
                return;
            }

            var intro = contents.SingleOrDefault(c => c.Type == "Introduction");

            this.Quotes = contents.Where(c => c.Type == "Quote").ToList();
            this.Identity = contents.Where(c => c.Type == "Identity").ToList();
            this.IntroductionHeader = intro?.Header;
            this.IntroductionBody = intro?.Value;
        }

        public List<ContentDto> Quotes { get; set; }

        public string IntroductionHeader { get; set; }

        public List<ContentDto> Identity { get; set; }

        public string IntroductionBody { get; set; }
    }
}