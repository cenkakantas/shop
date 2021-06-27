using System;
using System.Collections.Generic;
using System.Text;

namespace shop.Entities
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Description { get; set; }
        public double Point { get; set; }// kaç puan aldı
        public DateTime CreationDate { get; set; }
    }
}
