using egitim.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace shop.Entities
{
   public class Product:IEntity
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Views { get; set; }// görüntülenme sayisi
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
