using BlogProjectNew.DataAccessLayer.Abstract;
using BlogProjectNew.DataAccessLayer.Concrete;
using BlogProjectNew.DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;
using ProjectBlogNew.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectNew.DataAccessLayer.EntityFramework
{
    public class EfArticleRepository : GenericRepository<Article>, IArticleDal
    {
        public List<Article> GetListWithCategory()
        {
            using(var c=new Context())
            {
                return c.Articles.Include(x=> x.Category).ToList(); 
            }
        }
    }
}
