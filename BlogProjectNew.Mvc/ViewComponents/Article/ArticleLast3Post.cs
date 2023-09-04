using BlogProjectNew.BusinessLayer.Concrete;
using BlogProjectNew.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjectNew.Mvc.ViewComponents.Article
{
	public class ArticleLast3Post:ViewComponent
	{
		ArticleManager ar = new ArticleManager(new EfArticleRepository());
		public IViewComponentResult Invoke()
		{
			var values=ar.GetLast3Article();
			return View(values);
		}
	}
}
