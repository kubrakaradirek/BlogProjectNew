using BlogProjectNew.Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjectNew.Mvc.ViewComponents
{
	public class CommentList:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commentvalues = new List<UserComment>
			{
				new UserComment
				{
					Id = 1,
					UserName="Kubra"
				},
				new UserComment
				{
					Id = 2,
					UserName="Serpil"
				},
				new UserComment
				{
					Id = 3,
					UserName="Deligonul"
				}
			};
			return View(commentvalues);
		}
	}
}
