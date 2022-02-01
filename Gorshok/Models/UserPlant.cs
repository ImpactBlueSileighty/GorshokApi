using System;
using System.Collections.Generic;

#nullable disable

namespace GorshokApi.Models
{
    public partial class UserPlant
    {
        public int UserId { get; set; }
        public int CurrentPlantId { get; set; }

        public virtual CurrentPlant CurrentPlant { get; set; }
        public virtual User User { get; set; }
    }
}
