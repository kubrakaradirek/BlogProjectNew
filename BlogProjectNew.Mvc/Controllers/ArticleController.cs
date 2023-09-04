using BlogProjectNew.BusinessLayer.Concrete;
using BlogProjectNew.BusinessLayer.ValidationRules;
using BlogProjectNew.DataAccessLayer.EntityFramework;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectBlogNew.Entities.Concrete;

namespace BlogProjectNew.Mvc.Controllers
{
    [AllowAnonymous]
    public class ArticleController : Controller
    {
        ArticleManager arm=new ArticleManager(new EfArticleRepository());
        public IActionResult Index()
        {
            var values = arm.GetArticleListWithCategory();
            return View(values);
        }
        public IActionResult ArticleReadAll(int id)
        {
            ViewBag.i = id;
            var values = arm.GetBlogById(id);
            return View(values);
        }
        public IActionResult ArticleListByWriter()
        {
            var values=arm.GetArticleListByWriter(1);
            return View(values);
        }
        [HttpGet]
        public IActionResult ArticleAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ArticleAdd(Article p)
        {
            ArticleValidator av = new ArticleValidator();
            ValidationResult results = av.Validate(p);
            if (results.IsValid)
            {
                p.ArticleStatus = true;
                p.ArticleCCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                p.WriterId = 1;
                arm.TAdd(p);
                return RedirectToAction("ArticleListByWriter", "Article");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
