using BlogProjectNew.DataAccessLayer.Abstract;
using BlogProjectNew.DataAccessLayer.Repositories;
using ProjectBlogNew.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectNew.DataAccessLayer.EntityFramework
{
    public class EfAboutRepository:GenericRepository<About>,IAboutDal
    {
    }
}
