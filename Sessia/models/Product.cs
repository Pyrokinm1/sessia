using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sessia.models
{
    public partial class Product
    {
        public Product()
        {
            OrderProduct = new HashSet<OrderProduct>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public string Descrip { get; set; }
        public byte[] Image { get; set; }
        public float Sale { get; set; }

        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
    }
}
