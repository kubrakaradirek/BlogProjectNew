using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBlogNew.Entities.Concrete
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }
        public string AboutDetails { get; set; }
        public string AboutImage { get; set; }
        public bool AboutStatus { get; set; }
    }
}
