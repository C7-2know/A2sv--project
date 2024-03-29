using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogCrud.Models;
public class Comment:BaseEntity
{
    public int CommentId {get;set;}
    public string Text {get;set;}

}