using BlogProjectNew.BusinessLayer.Concrete;
using BlogProjectNew.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjectNew.Mvc.ViewComponents.Blog
{
	public class WriterLastArticle:ViewComponent
	{
		ArticleManager ar=new ArticleManager(new EfArticleRepository());
		public IViewComponentResult Invoke()
		{
			var values = ar.GetArticleListByWriter(1);
			return View(values);
		}
	}
}
