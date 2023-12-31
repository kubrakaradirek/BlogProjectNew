﻿using BlogProjectNew.BusinessLayer.Concrete;
using BlogProjectNew.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using ProjectBlogNew.Entities.Concrete;

namespace BlogProjectNew.Mvc.Controllers
{
    public class NewsLetterController : Controller
    {
        NewsLetterManager nm=new NewsLetterManager(new EfNewsLetterRepository());
        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult SubscribeMail(NewsLetter p)
        {
            p.MailStatus = true;
            nm.AddNewsLetter(p);
            return PartialView();
        }
    }
}
