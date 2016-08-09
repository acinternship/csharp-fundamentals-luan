using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Content { get; set; }
    }   
}
