using BlogProjectNew.BusinessLayer.Concrete;
using BlogProjectNew.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjectNew.Mvc.ViewComponents.Category
{
	
	public class CategoryList:ViewComponent
	{
		CategoryManager cm = new CategoryManager(new EfCategoryRepository());
		public IViewComponentResult Invoke()
		{
			var values = cm.GetList();
			return View(values);
		}

	}
}
