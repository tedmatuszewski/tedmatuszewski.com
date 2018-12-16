using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TM.BLL.Logic;

namespace TM.BLL.Pages
{
    public class AboutPage
    {
        public AboutPage(List<ContentLogic> contents)
        {
            this.Work = contents.Where(c => c.Type == "WorkHistory").OrderBy(w => w.Order).ToList();
            this.Education = contents.Where(c => c.Type == "EducationHistory").OrderBy(w => w.Order).ToList();
            this.Skills = contents.Where(c => c.Type == "Skill").OrderByDescending(c => c.Year).ToList();
        }

        public List<ContentLogic> Work { get; private set; }

        public List<ContentLogic> Education { get; private set; }

        public List<ContentLogic> Skills { get; private set; }
    }
}