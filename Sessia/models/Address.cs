using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sessia.models
{
    public partial class Address
    {
        public Address()
        {
            Order = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Address1 { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}
