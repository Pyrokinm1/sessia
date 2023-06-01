using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sessia.models
{
    public partial class User
    {
        public User()
        {
            Order = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Login { get; set; }
        public int Password { get; set; }
        public int RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Order> Order { get; set; }
    }
}
