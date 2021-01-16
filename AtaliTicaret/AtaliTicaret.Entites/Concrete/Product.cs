using AtaliTicaret.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtaliTicaret.Entites.Concrete
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductTitle { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductPhotoUrl { get; set; }
        public int CategoryId { get; set; }
        public int DealerId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Dealer Dealer { get; set; }

    }
}
