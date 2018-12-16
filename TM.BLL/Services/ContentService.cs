using System;
using System.Collections.Generic;
using System.Text;
using TM.BLL.Logic;
using TM.BLL.Pages;
using TM.DAL.Repositories;

namespace TM.BLL.Services
{
    public class ContentService
    {
        public HomePage GetHomePage()
        {
            var repository = new ContentRepository();
            var contents = repository.get().ConvertAll(c => new ContentLogic(c));
            var response = new HomePage(contents);

            return response;
        }

        public AboutPage GetAboutPage()
        {
            var repository = new ContentRepository();
            var contents = repository.get().ConvertAll(c => new ContentLogic(c));
            var response = new AboutPage(contents);

            return response;
        }
    }
}