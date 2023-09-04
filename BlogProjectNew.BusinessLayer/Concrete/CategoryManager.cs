using BlogProjectNew.BusinessLayer.Abstract;
using BlogProjectNew.DataAccessLayer.Abstract;
using BlogProjectNew.DataAccessLayer.EntityFramework;
using ProjectBlogNew.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectNew.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
       
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal=categoryDal;
        }
        

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetListAll();
        }

        public void TAdd(Category entity)
        {
            _categoryDal.Insert(entity);
        }

        public void TDelete(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public void TUpdate(Category t)
        {
            _categoryDal.Update(t);
        }
    }
}
