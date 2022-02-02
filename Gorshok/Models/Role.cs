using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

#nullable disable

namespace GorshokApi.Models
{
    public partial class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [IgnoreDataMember]
        public virtual ICollection<User> Users { get; set; }
    }
}
