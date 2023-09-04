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
    public class NewsLetterManager:INewsLetterService
    {
        INewsLetterDal _newsLetterDal;
        public NewsLetterManager(INewsLetterDal newsLetter)
        {
            _newsLetterDal = newsLetter;
            
        }

        public void AddNewsLetter(NewsLetter newsLetter)
        {
            _newsLetterDal.Insert(newsLetter);
        }
    }
}
