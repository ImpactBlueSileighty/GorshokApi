using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace GorshokApi.Models
{
    public partial class CurrentPlant
    {
        public int Id { get; set; }
        public int PlantId { get; set; }
        public decimal Temperature { get; set; }
        public int StatusId { get; set; }
        public decimal Progress { get; set; }
        
        [ForeignKey("PlantId")]
        public virtual Plant Plant { get; set; }
        [ForeignKey("StatusId")]
        public virtual Status Status { get; set; }

    }
}
