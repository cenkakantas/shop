using egitim.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace shop.Entities
{
   public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int? ParentCategoryId { get; set; } // Üst Kategorisi
        public string Slug { get; set; } 
        public DateTime CreationDate { get; set; }

        [ForeignKey("ParentCategoryId")]
        public virtual Category ParentCategory { get; set; }
        public ICollection<Category> SubCategories { get; set; } // Alt Kategoriler
    }
}
