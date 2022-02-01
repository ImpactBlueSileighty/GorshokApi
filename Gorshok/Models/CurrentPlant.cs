using System;
using System.Collections.Generic;

#nullable disable

namespace GorshokApi.Models
{
    public partial class CurrentPlant
    {
        public int Id { get; set; }
        public int PlantId { get; set; }
        public decimal Temperature { get; set; }
        public int StatusId { get; set; }
        public decimal Progress { get; set; }

        public virtual Plant Plant { get; set; }
        public virtual Status Status { get; set; }
    }
}
