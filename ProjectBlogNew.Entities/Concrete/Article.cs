using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBlogNew.Entities.Concrete
{
    public class Article
    {
        [Key]
        public int ArticleId { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleContent { get; set; }
        public string ArticleCThumbnailImage { get; set; }
        public string ArticleCImage { get; set; }
        public DateTime ArticleCCreateDate { get; set; }
        public bool ArticleStatus{ get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
		public int WriterId { get; set; }
		public Writer Writer { get; set; }
		public List<Comment> Comments { get; set; }
    }
}
