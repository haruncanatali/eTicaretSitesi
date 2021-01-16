using AtaliTicaret.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtaliTicaret.Entites.Concrete
{
    public class Dealer:IEntity
    {
        public int DealerId { get; set; }
        public string DealerName { get; set; }
        public string DealerTel { get; set; }
        public string DealerAdress { get; set; }
        public string DealerLogoUrl { get; set; }

        public virtual ICollection<Product> Products{ get; set; }
    }
}
