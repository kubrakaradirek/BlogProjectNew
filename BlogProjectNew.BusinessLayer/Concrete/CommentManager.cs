using BlogProjectNew.BusinessLayer.Abstract;
using BlogProjectNew.DataAccessLayer.Abstract;
using ProjectBlogNew.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectNew.BusinessLayer.Concrete
{
	public class CommentManager : ICommentService
	{
		ICommentDal _commentDal;
        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }
        public void CommentAdd(Comment comment)
		{
			_commentDal.Insert(comment);
		}

		public List<Comment> GetList(int id)
		{
			return _commentDal.GetListAll(x=>x.ArticleId==id);
		}
	}
}
