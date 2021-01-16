using AtaliTicaret.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtaliTicaret.Entites.Concrete
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Product> Products{ get; set; }
    }
}
