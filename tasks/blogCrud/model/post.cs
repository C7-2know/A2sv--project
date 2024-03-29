
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogCrud.Models
{
    public class Post:BaseEntity
    {
        public string Title {get;set;}
        public string Content {get;set;}
        public virtual ICollection<Comment> Comments {get;set; }

    }
}
