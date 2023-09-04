using BlogProjectNew.BusinessLayer.Concrete;
using BlogProjectNew.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace BlogProjectNew.Mvc.Models.Comment
{
    public class CommentListByArticle:ViewComponent
    {
        CommentManager cm=new CommentManager(new EfCommentRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = cm.GetList(id);
            return View(values);
        }
    }
}
