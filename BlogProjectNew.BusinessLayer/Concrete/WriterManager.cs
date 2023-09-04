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
	public class WriterManager : IWriterService
	{
		IWriterDal _writerDal;
        public WriterManager(IWriterDal writerDal)
        {
			_writerDal = writerDal;
            
        }
        public void WriterAdd(Writer writer)
		{
			_writerDal.Insert(writer);
		}
	}
}
