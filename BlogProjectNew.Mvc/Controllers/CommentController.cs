﻿using BlogProjectNew.BusinessLayer.Concrete;
using BlogProjectNew.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using ProjectBlogNew.Entities.Concrete;

namespace BlogProjectNew.Mvc.Controllers
{
	public class CommentController : Controller
	{
		CommentManager cm=new CommentManager(new EfCommentRepository());
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}
        [HttpPost]
        public PartialViewResult PartialAddComment(Comment p)
        {
			p.CommentDate=DateTime.Parse(DateTime.Now.ToShortDateString());
			p.CommentStatus = true;
			p.ArticleId = 20;
			cm.CommentAdd(p);
            return PartialView();
        }
        public PartialViewResult CommentListByArticle(int id)
		{
			var values=cm.GetList(id);
			return PartialView(values);
		}
	}
}
