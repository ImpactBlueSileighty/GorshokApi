using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

#nullable disable

namespace GorshokApi.Models
{
    public partial class Plant
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [IgnoreDataMember]
        public virtual ICollection<CurrentPlant> CurrentPlants { get; set; }
    }
}
