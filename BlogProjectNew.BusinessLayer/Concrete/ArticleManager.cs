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
	public class ArticleManager : IArticleService
	{
		IArticleDal _articleDal;
        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }
      

        public List<Article> GetArticleListWithCategory()
        {
			return _articleDal.GetListWithCategory();
        }

        public Article GetById(int id)
		{
			throw new NotImplementedException();
		}
		public List<Article> GetBlogById(int id)
		{
			return _articleDal.GetListAll(x=>x.ArticleId==id);
		}
		public List<Article> GetList()
		{
			return _articleDal.GetListAll();
		}
		public List<Article> GetLast3Article()
		{
			return _articleDal.GetListAll().Take(3).ToList();
		}

		public List<Article> GetArticleListByWriter(int id)
		{
			return _articleDal.GetListAll(x=>x.WriterId==id);
		}

        public void TAdd(Article entity)
        {
            _articleDal.Insert(entity);
        }

        public void TDelete(Article entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Article t)
        {
            throw new NotImplementedException();
        }
    }
}
